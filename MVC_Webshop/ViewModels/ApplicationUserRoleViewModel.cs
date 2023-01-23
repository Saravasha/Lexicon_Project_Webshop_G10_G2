using System.ComponentModel.DataAnnotations;
using MVC_Webshop.Data;

namespace MVC_Webshop.ViewModels
{
    public class ApplicationUserRoleViewModel
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<ApplicationRole> Roles { get; set; } = new List<ApplicationRole>();
    }
}
