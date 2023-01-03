using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PassWordHash { get; set; }
        public string CreditCardNumber { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public int ShoppingCartId { get; set; }
        public Shipment Shipment { get; set; }
        public List<Shipment> Shipments { get; set; } = new();
        public int ShipmentId { get; set; }
        public Order Order { get; set; }
        public List<Order> Orders { get; set; } = new();
        public int OrderId { get; set; }
    }
}
