using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Webshop.Models
{
    public class Order
    {

        public string OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ExpectedDelivery { get; set; }
        public bool Shipped { get; set; }
        //public List<Dictionary<string, double>> ProductList { get; set; }

        //public List<string> ProductList { get; set; } = new();
        public DateTime OrderDate { get; set; }
        //public List<Product> Products { get; set; } = new();

        //public Order()
        //{
        //    ProductList = new List<string>();
        //}

        //public void AddProduct(string name)
        //{
        //    ProductList.Add(name);

        //}
    }
}