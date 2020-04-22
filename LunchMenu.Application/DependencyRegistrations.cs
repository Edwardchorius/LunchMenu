using LunchMenu.Application.Interfaces;
using LunchMenu.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


public static class DependencyRegistrations
{
    public static IServiceCollection RegisterApplicationDepenencies(this IServiceCollection services)
    {
        services.AddTransient<IHashingService, HashingService>();
        services.AddTransient<ICustomerService, CustomerService>();

        return services;
    }
}

