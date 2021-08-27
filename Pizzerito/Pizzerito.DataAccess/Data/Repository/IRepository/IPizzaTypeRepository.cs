using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System.Collections.Generic;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IPizzaTypeRepository : IRepository<PizzaType>
    {

        IEnumerable<SelectListItem> GetToppingListForDropDown();
        void Update(PizzaType pizzaType);
    }
}
