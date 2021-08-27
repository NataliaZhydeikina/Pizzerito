using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pizzerito.DataAccess.Data.Repository
{
    public class ToppingTypeRepository : Repository<ToppingType>, IToppingTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public ToppingTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetToppingTypeListForDropDown()
        {
            return _db.ToppingType.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(ToppingType toppingType)
        {
            var objFromDb = _db.ToppingType.FirstOrDefault(s => s.Id == toppingType.Id);

            objFromDb.Name = toppingType.Name;


            _db.SaveChanges();
        }
    }
}
