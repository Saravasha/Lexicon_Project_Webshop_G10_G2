using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_Webshop.ViewModels
{
    public class ProductCreateViewModel
    {
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

        // PRODUCT IMAGE UPLOAD

        [Display(Name = "Description:")]
        public int? Quantity { get; set; }
    }
}
