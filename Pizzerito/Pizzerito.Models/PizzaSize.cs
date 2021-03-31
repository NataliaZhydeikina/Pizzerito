using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pizzerito.Models
{
    public class PizzaSize
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Pizza Size")]
        public string Size { get; set; }

    }
}
