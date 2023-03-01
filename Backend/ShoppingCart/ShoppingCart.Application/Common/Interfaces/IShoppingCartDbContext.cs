using Microsoft.EntityFrameworkCore;
using ShoppingCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Common.Interfaces
{
    public interface IShoppingCartDbContext
    {
        DbSet<Users> Users { get; }
        DbSet<RefreshTokens> RefreshTokens { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
