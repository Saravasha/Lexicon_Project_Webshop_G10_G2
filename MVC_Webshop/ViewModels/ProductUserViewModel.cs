using MVC_Webshop.Data;
using MVC_Webshop.Models;

namespace MVC_Webshop.ViewModels
{
    public class ProductUserViewModel
    {
        public Product Product { get; set; }
        public ApplicationUser User { get; set; }


        //public ProductUserViewModel ProductUser { get; set; } = new ProductUserViewModel();

    }
}
