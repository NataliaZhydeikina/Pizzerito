using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IToppingTypeRepository : IRepository<ToppingType>
    {
        IEnumerable<SelectListItem> GetToppingTypeListForDropDown();

        void Update(ToppingType toppingType);
    }
}
