using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shoppingcart.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        [ForeignKey("UserDetails")]
        public int UserId { get; set; }

        [ForeignKey("ProductDetails")]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; } = 1;

        public decimal Price { get; set; }

    }
}
