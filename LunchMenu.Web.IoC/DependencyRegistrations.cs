
using LunchMenu.Application.Interfaces;
using LunchMenu.Application.Interfaces.Repositories;
using LunchMenu.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LunchMenu.Persistence.Interfaces;
using LunchMenu.Persistence.Services;

namespace LunchMenu.Persistence
{
    public static class DependencyRegistrations
    {
        public static IServiceCollection RegisterPersistenceDepenencies(this IServiceCollection services, string DbConnectionString)
        {
            services.AddDbContext<LunchMenuDbContext>(c => c.UseSqlServer(DbConnectionString));
            services.AddTransient<IDataUnitOfWork, DataUnitOfWork>();
            services.AddTransient<IDataSeedingService, DataSeedingService>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IFeastOrderRepository, FeastOrderRepository>();
            services.AddTransient<IFeastRepository, FeastRepository>();

            services.RegisterApplicationDepenencies();

            return services;
        }
    }
}
