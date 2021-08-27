using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizzerito.DataAccess.Data.Repository
{
    public class PizzaCrustFlavorRepository : Repository<PizzaCrustFlavor>, IPizzaCrustFlavorRepository
    {
        private readonly ApplicationDbContext _db;

        public PizzaCrustFlavorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetPizzaCrustFlavorListForDropDown()
        {
            return _db.PizzaCrustFlavor.Select(i => new SelectListItem()
            {
                //value of list uses int for placement
                Text = i.CrustFlavor,
                Value = i.Id.ToString(),
            });
        }

        public void Update(PizzaCrustFlavor pizzaCrustFlavor)
        {
            var objFromDb = _db.PizzaCrustFlavor.FirstOrDefault(s => s.Id == pizzaCrustFlavor.Id);

            objFromDb.CrustFlavor = pizzaCrustFlavor.CrustFlavor;
            objFromDb.CrustFlavorDescription = pizzaCrustFlavor.CrustFlavorDescription;


            _db.SaveChanges();
        }
    }
}
