using Microsoft.AspNetCore.Identity;

namespace MVC_Webshop.Areas.Identity.Data
{
    public class ApplicationRole : IdentityRole
    {

        //public string Id { get; set; }
        //public string Name { get; set; }

        public string? UserId { get; set; }
        //public string NormalizedName { get; set; }
        //public string ConcurrencyStamp { get; set; }

    }
}
