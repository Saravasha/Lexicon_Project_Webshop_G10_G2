using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public List<Product> Products { get; set; } = new();

    }
}