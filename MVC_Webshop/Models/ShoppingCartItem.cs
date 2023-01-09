using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public string ShoppingCartItemId { get; set; }
        public string ProductId { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
