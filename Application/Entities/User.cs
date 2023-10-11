using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Entities;

[Table("Users")]
public class User
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
    [Column("email")]
    public string Email { get; set; }
    [Column("username")]
    public string Username { get; set; }

    public ICollection<ShoppingListUsers> ShoppingListUser { get; }
}