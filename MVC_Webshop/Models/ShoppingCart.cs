using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; } = new();

    }
}
