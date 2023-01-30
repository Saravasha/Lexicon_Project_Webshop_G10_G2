using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_Webshop.ViewModels
{
    public class CategoryCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        [Display(Name = "Category Name:")]
        public string Name { get; set; }

        [Display(Name = "Category:")]
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId { get; set; }
    }
}
