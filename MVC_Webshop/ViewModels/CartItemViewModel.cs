using MVC_Webshop.Controllers;
using MVC_Webshop.Models;

namespace MVC_Webshop.ViewModels
{
    public class CartItemViewModel
    {

        public Cart Cart { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

    }
}
