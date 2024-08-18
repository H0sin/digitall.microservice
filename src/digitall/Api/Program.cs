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
using Microsoft.Extensions.DependencyInjection;
using Api.Services;
using Api.Factory;
using Application.Jobs;
using Application.Utilities;
using Quartz;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddServices();

builder.Services.AddHttpContextAccessor();

builder.Services.AddSingleton<BotService>();
builder.Services.AddSingleton<TelegramBotClientFactory>();

builder.Services.AddControllers().AddNewtonsoftJson();

ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

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
    //
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

#region jobs

builder.Services.AddQuartz(q =>
{
    q.UseMicrosoftDependencyInjectionJobFactory();

    var jobSettings = builder.Configuration.GetSection("Quartz:Jobs").Get<List<JobSettings>>();

    if (jobSettings != null)
        foreach (var settings in jobSettings)
        {
            var jobType = Type.GetType(settings.JobType);
            if (jobType == null)
            {
                throw new InvalidOperationException($"Job type '{settings.JobType}' could not be found.");
            }

            var jobKey = new JobKey(settings.JobName, settings.JobGroup);

            switch (settings.JobName)
            {
                case "DeleteExpiredNotificationsJob":
                    q.AddJob<DeleteExpiredNotificationsJob>(opts => opts.WithIdentity(jobKey));
                    break;
                case "SendTelegramNotificationJob":
                    q.AddJob<SendTelegramNotificationJob>(opts => opts.WithIdentity(jobKey));
                    break;
            }

            q.AddTrigger(opts => opts
                .ForJob(jobKey)
                .WithIdentity(settings.TriggerName, settings.TriggerGroup)
                .WithCronSchedule(settings.CronSchedule));
        }
});

builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

#endregion

var app = builder.Build();

#region bot

var botService = app.Services.GetRequiredService<BotService>();
var cancellationTokenSource = new CancellationTokenSource();

#endregion

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

app.MigrateDatabase<DigitallDbContext>((context, services) =>
{
    var logger = services.GetService<ILogger<DigitallDbContext>>();
    botService.StartAllBotsAsync(cancellationTokenSource.Token).GetAwaiter().GetResult();
}).Run();