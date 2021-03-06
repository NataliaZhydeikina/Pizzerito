using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizzerito.DataAccess.Data.Repository
{
    public class PizzaSizeRepository : Repository<PizzaSize>, IPizzaSizeRepository
    {
        private readonly ApplicationDbContext _db;

        public PizzaSizeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetPizzaSizeListForDropDown()
        {
            return _db.PizzaSize.Select(i => new SelectListItem()
            {
                //value of list uses int for placement
                Text = i.Size,
                Value = i.Id.ToString(),
            });
        }

        public void Update(PizzaSize pizzaSize)
        {
            var objFromDb = _db.PizzaSize.FirstOrDefault(s => s.Id == pizzaSize.Id);

            objFromDb.Size = pizzaSize.Size;



            _db.SaveChanges();
        }
    }
}
