using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IPizzaSizeRepository : IRepository<PizzaSize>
    {
        IEnumerable<SelectListItem> GetPizzaSizeListForDropDown();
      

        void Update(PizzaSize pizzaSize);
    }
}
