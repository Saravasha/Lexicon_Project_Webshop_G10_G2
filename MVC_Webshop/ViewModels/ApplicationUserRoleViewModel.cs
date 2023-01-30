

using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.ViewModels
{
    public class ApplicationUserRoleViewModel
    {

        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}
