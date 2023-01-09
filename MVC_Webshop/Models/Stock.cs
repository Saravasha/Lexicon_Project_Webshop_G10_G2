using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Stock
    {
        [Key]
        public string StockId { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductId { get; set; }
        public List<Product> Products { get; set; } = default!; 

    }
}