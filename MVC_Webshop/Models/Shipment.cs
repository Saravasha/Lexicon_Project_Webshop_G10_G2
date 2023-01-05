﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Shipment
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
    }
}