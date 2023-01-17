using MVC_Webshop.Areas.Identity.Data;

namespace MVC_Webshop.ViewModels
{
    public class CreateApplicationUserViewModel
    {

        public ApplicationUserViewModel NewUser { get; set; } = new ApplicationUserViewModel();

        public List<ApplicationUser> Users = new List<ApplicationUser>();

    }
}
