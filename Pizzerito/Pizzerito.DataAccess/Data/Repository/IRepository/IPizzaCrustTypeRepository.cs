using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.Models;
using System.Collections.Generic;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IPizzaCrustTypeRepository : IRepository<PizzaCrustType>
    {
        IEnumerable<SelectListItem> GetPizzaCrustTypeListForDropDown();


        void Update(PizzaCrustType pizzaCrustType);
    }
}
