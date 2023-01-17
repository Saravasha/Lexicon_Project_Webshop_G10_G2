

using Microsoft.AspNetCore.Identity;
using MVC_Webshop.Models;

namespace MVC_Webshop.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? CreditCardNumber { get; set; }
    public int? CartId { get; set; }
    public Cart? Cart { get; set; }
    public int? OrderId { get; set; }
    public string? RoleId { get; set; }
    public List<Order>? Orders { get; set; }

}
