using System.ComponentModel.DataAnnotations;
using MVC_Webshop.Models;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Webshop.ViewModels
{
    public class ProductCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [Display(Name = "Product Name:")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Brand Name is required")]
        [Display(Name = "Brand Name:")]
        public string? Brand { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price:")]
        public double? Price{ get; set; }

        [Required(ErrorMessage = "Short Description is required")]
        [Display(Name = "Short Description:")]
        public string? ShortDescription { get; set; }

        [Display(Name = "Description:")]
        public string? Description { get; set; }


        [Display(Name = "Product Image")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Product Image")]
        [NotMapped]
        public IFormFile ImageUp { get; set; }



        //public IFormFile ImageUrl { get; set; }

        [Display(Name = "Stock:")]
        public int? Quantity { get; set; }

        //public int CategoryId { get; set; }


        public List<int>? CategoryIds { get; set; } = new();

        [Display(Name = "Category:")]
        [Required(ErrorMessage = "Category is Required")]
        public List<Category> categoriesMulti { get; set; } = new();
    }
}
