using MVC_Webshop.Data;

namespace MVC_Webshop.ViewModels
{
    public class CreateApplicationRoleViewModel
    {

        public ApplicationRoleViewModel NewRole { get; set; } = new ApplicationRoleViewModel();

        public List<ApplicationRole> Roles = new List<ApplicationRole>();

    }
}
