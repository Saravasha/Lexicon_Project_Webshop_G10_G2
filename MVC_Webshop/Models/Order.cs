using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }

        public Product Product { get; set; }

    }
}
