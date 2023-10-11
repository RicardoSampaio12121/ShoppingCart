using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Entities;

[Table("shoppingLists")]
public class ShoppingList
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    
    public ICollection<ShoppingListUsers> ShoppingListUser { get; }
}