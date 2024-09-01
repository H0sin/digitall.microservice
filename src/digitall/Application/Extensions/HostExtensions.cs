using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Application.Extensions;

public static class HostExtensions
{
    public static IHost MigrateDatabase<TContext>(this IHost host,
        Action<TContext, IServiceProvider> seeder,
        int? retry = 0) where TContext : DbContext
    {
        int retryForAvailability = retry.Value;

        using (IServiceScope scope = host.Services.CreateScope())
        {
            IServiceProvider services = scope.ServiceProvider;
            ILogger<TContext> logger = services.GetRequiredService<ILogger<TContext>>();

            var context = services.GetService<TContext>();
            try
            {
                logger.LogInformation("migrating started for sql server");
                InvokeSeeder(seeder, context, services);
                logger.LogInformation("migrating has been don for sql server");
            }
            catch (SqlException ex)
            {
                logger.LogError(ex, "an Error occurred");

                if (retryForAvailability < 50)
                {
                    retryForAvailability++;
                    Thread.Sleep(2000); 
                    MigrateDatabase(host, seeder, retryForAvailability);
                }

                throw ex;
            }

            return host;
        }
    }

    private static void InvokeSeeder<TContext>(
        Action<TContext, IServiceProvider> seeder,
        TContext context,
        IServiceProvider services) where TContext : DbContext
    {
        context.Database.Migrate();
        seeder(context, services);
    }
}