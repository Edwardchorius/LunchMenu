using LunchMenu.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence
{
    public static class DependencyRegistrations
    {
        public static IServiceCollection RegisterPersistenceDepenencies(this IServiceCollection services, string DbConnectionString)
        {
            services.AddDbContext<LunchMenuDbContext>(c => c.UseSqlServer(DbConnectionString));
            services.AddTransient<IDataUnitOfWork, DataUnitOfWork>();

            return services;
        }
    }
}
