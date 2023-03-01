using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entities
{
    [Table("refresh_tokens")]
    public class RefreshTokens
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
