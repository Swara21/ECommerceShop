using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Shoppingcart.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Enter Email")]
        public string? EmailId { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        public string? Password { get; set; }
    }
}
