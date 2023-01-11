using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Webshop.Models
{

    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public List<Item> Items { get; set; }
    }
}