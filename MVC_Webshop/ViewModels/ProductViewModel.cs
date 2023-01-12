using MVC_Webshop.Models;

namespace MVC_Webshop.ViewModels
{
    public class ProductViewModel
    {
        public List<Product> listOfProducts { get; set; } = new();
    }
}
