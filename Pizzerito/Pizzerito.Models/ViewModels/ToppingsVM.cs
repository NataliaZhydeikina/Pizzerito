using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Pizzerito.Models.ViewModels
{
    public class ToppingsVM
    {
        public Toppings Toppings { get; set; }

        public IEnumerable<SelectListItem> ToppingTypeList { get; set; }
    }
}
