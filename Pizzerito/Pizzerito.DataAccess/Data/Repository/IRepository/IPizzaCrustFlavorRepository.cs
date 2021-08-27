using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System.Collections.Generic;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IPizzaCrustFlavorRepository : IRepository<PizzaCrustFlavor>
    {
        IEnumerable<SelectListItem> GetPizzaCrustFlavorListForDropDown();


        void Update(PizzaCrustFlavor pizzaCrustFlavor);
    }
}
