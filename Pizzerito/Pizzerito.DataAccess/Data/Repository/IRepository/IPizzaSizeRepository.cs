using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System.Collections.Generic;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IPizzaSizeRepository : IRepository<PizzaSize>
    {
        IEnumerable<SelectListItem> GetPizzaSizeListForDropDown();


        void Update(PizzaSize pizzaSize);
    }
}
