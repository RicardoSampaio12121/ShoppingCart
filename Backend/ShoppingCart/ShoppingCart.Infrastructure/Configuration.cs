using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Application.Common.Interfaces;
using ShoppingCart.Infrastructure.Persistence;

namespace ShoppingCart.Infrastructure
{
    public static class Configuration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShoppingCartDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ShoppingCartDb"), builder => builder.MigrationsAssembly(typeof(ShoppingCartDbContext).Assembly.FullName));
            });

            services.AddScoped<IShoppingCartDbContext, ShoppingCartDbContext>(provider => provider.GetRequiredService<ShoppingCartDbContext>());

            return services;
        }
    }
}
