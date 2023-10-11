using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShoppingCart.Entities;

namespace ShoppingCart.Database;

public class Context: DbContext
{
    private readonly IConfiguration _configuration;
    
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }
   
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<ShoppingList> ShoppingLIs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .HasMany(a => a.ShoppingListUser)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId);

        builder.Entity<ShoppingList>()
            .HasMany(a => a.ShoppingListUser)
            .WithOne(b => b.ShoppingList)
            .HasForeignKey(b => b.ShoppingListId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DbConnectionString");
        optionsBuilder.UseNpgsql(connectionString);
    }
}