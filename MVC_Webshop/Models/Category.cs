using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        //public Product Product { get; set; }
    }
}