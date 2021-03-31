using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IToppingsRepository : IRepository<Toppings>
    {

        IEnumerable<SelectListItem> GetToppingListForDropDown();

        void Update(Toppings toppings);
    }
}
