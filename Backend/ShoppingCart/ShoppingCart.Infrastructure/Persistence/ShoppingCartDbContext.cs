using Microsoft.EntityFrameworkCore;
using ShoppingCart.Application.Common.Interfaces;
using ShoppingCart.Domain.Entities;

namespace ShoppingCart.Infrastructure.Persistence
{
    public class ShoppingCartDbContext : DbContext, IShoppingCartDbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options): base(options)
        {
        }

        public DbSet<Users> Users => Set<Users>();
        public DbSet<RefreshTokens> RefreshTokens => Set<RefreshTokens>();

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
