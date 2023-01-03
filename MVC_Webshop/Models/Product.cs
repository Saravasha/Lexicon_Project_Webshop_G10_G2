using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public Category Category { get; set; }
    }
}
