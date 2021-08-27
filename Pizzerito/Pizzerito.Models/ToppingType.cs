using System.ComponentModel.DataAnnotations;

namespace Pizzerito.Models
{
    public class ToppingType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Topping Type")]
        public string Name { get; set; }
    }
}
