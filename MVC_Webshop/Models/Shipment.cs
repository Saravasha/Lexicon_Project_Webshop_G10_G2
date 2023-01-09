using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Shipment
    {
        [Key]
        public string ShipmentId { get; set; }
        public string ShoppingCartId { get; set; }
    }
}