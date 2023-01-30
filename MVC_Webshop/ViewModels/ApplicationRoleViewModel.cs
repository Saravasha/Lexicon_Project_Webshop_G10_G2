
using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.ViewModels
{
    public class ApplicationRoleViewModel
    {

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }


    }
}
