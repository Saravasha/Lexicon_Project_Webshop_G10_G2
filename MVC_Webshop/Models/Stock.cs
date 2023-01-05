using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; } = default!; 

    }
}