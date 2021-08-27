using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System.Collections.Generic;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IToppingTypeRepository : IRepository<ToppingType>
    {
        IEnumerable<SelectListItem> GetToppingTypeListForDropDown();

        void Update(ToppingType toppingType);
    }
}
