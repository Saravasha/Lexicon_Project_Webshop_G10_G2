using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVC_Webshop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ExpectedDelivery { get; set; }
        public bool Shipped { get; set; }
        public DateTime OrderDate { get; set; }
        public ApplicationUser User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}