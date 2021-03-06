using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Pizzerito.Models.ViewModels
{
    public class PizzaTypeVM
    {
        public PizzaType PizzaType { get; set; }


        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> ToppingTypeList { get; set; }
        public IEnumerable<SelectListItem> PizzaCrustTypeList { get; set; }
        public IEnumerable<SelectListItem> PizzaCrustFlavorList { get; set; }
        public IEnumerable<SelectListItem> PizzaSizeList { get; set; }
        public IEnumerable<SelectListItem> ToppingsList { get; set; }
    }
}
