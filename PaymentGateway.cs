using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Shoppingcart.Models
{
    public class PaymentGateway
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set; }

        [ForeignKey("UserDetails")]
        public int UserId { get; set; }

        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public string? Tstatus { get; set; }
        public string? Mode { get; set; }
        public string? Code { get; set; }
    }
}

