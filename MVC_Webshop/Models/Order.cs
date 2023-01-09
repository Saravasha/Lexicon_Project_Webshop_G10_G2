﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; } = new();

    }
}