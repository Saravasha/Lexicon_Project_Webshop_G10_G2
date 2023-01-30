using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Webshop.Models
{

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }

        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile ImageUp { get; set; }

        //Quantity in Stock
        public int? Quantity { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; } = new();
    }
}