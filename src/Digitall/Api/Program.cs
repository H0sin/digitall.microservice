using System.Reflection;
using System.Text;
using Api.Filters;
using Api.Middleware;
using Asp.Versioning;
using Application.Extensions;
using Application.Helper;
using Data.Context;
using Ioc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Formatting.Json;
using Telegram.Bot;
using Telegram.Bot.Controllers;
using Telegram.Bot.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddServices();
builder.Services.AddHttpContextAccessor();

#region telegram web hook (get configuration)

// IConfigurationSection? botConfigurationSection = builder.Configuration.GetSection(BotConfiguration.Configuration);
// builder.Services.Configure<BotConfiguration>(botConfigurationSection);

// BotConfiguration? botConfiguration = botConfigurationSection.Get<BotConfiguration>();

// builder.Services.AddHttpClient("telegram_bot_client")
//     .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
//     {
//         BotConfiguration? botConfig = sp.GetConfiguration<BotConfiguration>();
//         TelegramBotClientOptions options = new(botConfig!.BotToken);
//         return new TelegramBotClient(options, httpClient);
//     });

// // Dummy business-logic service
// builder.Services.AddScoped<UpdateHandlers>();

// There are several strategies for completing asynchronous tasks during startup.
// Some of them could be found in this article https://andrewlock.net/running-async-tasks-on-app-startup-in-asp-net-core-part-1/
// We are going to use IHostedService to add and later remove Webhook
// builder.Services.AddHostedService<ConfigureWebhook>();

#endregion

builder.Services.AddControllers();

#region cors config

builder.Services.AddCors(option =>
{
    option.DefaultPolicyName = "DigitallCors";
    option.AddDefaultPolicy(configure =>
    {
        configure.AllowAnyHeader();
        configure.AllowAnyMethod();
        configure.AllowAnyOrigin();
    });
});

#endregion

#region sql config

builder.Services.AddDbContext<DigitallDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DigitallConnection"), op => op.UseHierarchyId());
});

#endregion

#region serilog

Log.Logger = new LoggerConfiguration()
    .WriteTo.File(new JsonFormatter(), @"log\log-.json",
        rollingInterval: RollingInterval.Day,
        rollOnFileSizeLimit: true,
        fileSizeLimitBytes: 123456)
    .CreateLogger();

builder.Services.AddScoped<ExceptionHandler>();

#endregion

#region api versening and swagger

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1);
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version"));
}).AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'V";
    options.SubstituteApiVersionInUrl = true;
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Digitall API v1",
        Description = "Authentication and Authorization in Digitall API with JWT and Swagger"
    });

    c.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = "Digitall API v2",
        Description = "Authentication and Authorization in Digitall API with JWT and Swagger"
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Description =
            "Enter �Bearer� [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJMbGciMiJIUzI1NiIsMnR5cCI6IkpXVCJ9\"",
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = JwtBearerDefaults.AuthenticationScheme,
                    Type = ReferenceType.SecurityScheme
                }
            },
            Array.Empty<string>()
        }
    });

    // string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
    // string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    // c.IncludeXmlComments(xmlPath);
});

#endregion

#region authentication

builder.Services.AddAuthentication(opt =>
    {
        opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration.GetValue<string>("JWT:ValidIssuer"),
            ValidAudience = builder.Configuration.GetValue<string>("JWT:ValidAudience"),
            IssuerSigningKey =
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("JWT:SecurityKey")))
        };
    });

#endregion

var app = builder.Build();

#region middelewear

app.UseMiddleware<AuthenticationMiddleware>();

#endregion

if (app.Environment.IsDevelopment())
{
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "JWT Auth Demo V1");
    c.SwaggerEndpoint("/swagger/v2/swagger.json", "JWT Auth Demo V2");
});

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseCors("DigitallCors");
// app.MapBotWebhookRoute<BotController>(route: botConfiguration!.Route);

app.MigrateDatabase<DigitallDbContext>((context, services) =>
{
    var logger = services.GetService<ILogger<DigitallDbContext>>();
}).Run();