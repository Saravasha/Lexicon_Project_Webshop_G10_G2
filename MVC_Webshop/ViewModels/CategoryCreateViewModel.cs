using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_Webshop.ViewModels
{
    public class CategoryCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [Display(Name = "Product Name:")]
        public string Name { get; set; }

        [Display(Name = "Category:")]
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId { get; set; }
    }
}
