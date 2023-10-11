using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Entities;

[Table("shoppingListUsers")]
public class ShoppingListUsers
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
    [Column("userId")]
    public long UserId { get; set; }
    [Column("shoppingListId")]
    public long ShoppingListId { get; set; }
    
    public User User { get; set; }
    public ShoppingList ShoppingList { get; set; }
    
}