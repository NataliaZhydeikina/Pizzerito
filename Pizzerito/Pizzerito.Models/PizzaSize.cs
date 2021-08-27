using System.ComponentModel.DataAnnotations;

namespace Pizzerito.Models
{
    public class PizzaSize
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Pizza Size")]
        public string Size { get; set; }

    }
}
