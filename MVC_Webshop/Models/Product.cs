using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Brand { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public int Quantity { get; set; }
        public string? CategoryId { get; set; }
        public List<Category>? Categories { get; set; }
    }
}