using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchMenu.Persistence;
using LunchMenu.Persistence.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LunchMenu.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            InitializeData(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void InitializeData(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

                try
                {
                    var context = scope.ServiceProvider.GetService<LunchMenuDbContext>();
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    var dataSeeder = scope.ServiceProvider.GetService<IDataSeedingService>();
                    dataSeeder.Seed();

                    logger.LogInformation("Database initialized");
                }
                catch (Exception e)
                {
                    logger.LogError(e, "An error occurred while initializing the database.");
                    throw e;
                }
            }
        }
    }
}
