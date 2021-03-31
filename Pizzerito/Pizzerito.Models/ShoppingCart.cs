﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pizzerito.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }
        public int Id { get; set; }

        public int PizzaTypeId { get; set; }
        [NotMapped]
        [ForeignKey("PizzaTypeId")]
        public virtual PizzaType PizzaType { get; set; }

        public string ApplicationUserId { get; set; }

        [NotMapped]
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name ="Qty")]
        [Range(1,20, ErrorMessage = "You can not have less than 1 or greater than 20 items.")]
        public int Count { get; set; }
    }
}