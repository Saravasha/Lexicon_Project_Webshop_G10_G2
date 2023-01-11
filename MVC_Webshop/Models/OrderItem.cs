﻿namespace MVC_Webshop.Models
{
    public class OrderItem
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int OrderItemId { get; set; }
        public Order Order { get; set; }
    }
}