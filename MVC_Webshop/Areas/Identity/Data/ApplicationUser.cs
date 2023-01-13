

using Microsoft.AspNetCore.Identity;

namespace MVC_Webshop.Models;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? CreditCardNumber { get; set; }
    public int CartId { get; set; }
    public Cart Cart { get; set; }
    public int OrderId { get; set; }
    public List<Order> Orders { get; set; }

}   
 