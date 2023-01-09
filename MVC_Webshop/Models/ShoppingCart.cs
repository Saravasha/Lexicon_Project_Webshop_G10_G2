using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class ShoppingCart
    {
        [Key]
        public string ShoppingCartId { get; set; }
        public string UserId { get; set; }
        public int ShoppingCartItemQuantity { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new();

    }
}