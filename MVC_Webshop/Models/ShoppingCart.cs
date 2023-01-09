using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class ShoppingCart
    {
        [Key]
        public string ShoppingCartId { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public List<Product> Products { get; set; } = new();

    }
}