using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System.Collections.Generic;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IToppingsRepository : IRepository<Toppings>
    {

        IEnumerable<SelectListItem> GetToppingListForDropDown();

        void Update(Toppings toppings);
    }
}
