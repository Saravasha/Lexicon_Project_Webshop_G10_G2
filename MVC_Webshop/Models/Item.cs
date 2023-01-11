using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{

    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int ProductIdRef { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public Cart? Cart { get; set; }

    }
}
