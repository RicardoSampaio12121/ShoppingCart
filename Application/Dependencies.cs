using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Database;

namespace ShoppingCart;

public static class Dependencies
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddDbContext<Context>();
        
        return services;
    }
}