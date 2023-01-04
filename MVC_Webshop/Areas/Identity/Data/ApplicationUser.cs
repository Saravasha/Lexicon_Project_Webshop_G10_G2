using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MVC_Webshop.Models;

    public class ApplicationUser : IdentityUser
{
    public override string UserName { get; set; } 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public override string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string CreditCardNumber { get; set; }
    public int RoleId { get; set; }
    //public Role Role { get; set; } 
    //public List<Role> Roles { get; set; }
    public int ShoppingCartId { get; set; }
    //public ShoppingCart ShoppingCart { get; set; }
    //public Shipment Shipment { get; set; } 
    public int ShipmentId { get; set; }
    //public List<Shipment> Shipments { get; set; } 
    public int OrderId { get; set; }
    //public Order Order { get; set; } 
    //public List<Order> Orders { get; set; } 
}
    