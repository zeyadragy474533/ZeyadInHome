using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeyadInHome.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; } 

        public decimal TotalAmount { get; set; }

        public string Status { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderItem>? OrderDetails { get; set; }
    }
}
