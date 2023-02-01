using MVC_Webshop.Controllers;
using MVC_Webshop.Data;
using MVC_Webshop.Models;

namespace MVC_Webshop.ViewModels
{
    public class CartItemViewModel
    {

        public Cart Cart { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
		public List<int> Items { get; set; } = new List<int>();
		public ApplicationUser UserId { get; set; }

    }
}
