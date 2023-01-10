﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Webshop.Models
{

    public class Cart
    {
       
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Item>? Items { get; set; } = new List<Item>();

    }
}