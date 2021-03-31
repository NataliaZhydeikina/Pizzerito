using Pizzerito.DataAccess;
using Pizzerito.DataAccess.Data.Repository;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzerito.DataAccess.Data.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {

        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(OrderDetails orderDetails)
        {
            var orderDetailsFromDb = _db.OrderDetails.FirstOrDefault(m => m.Id == orderDetails.Id);
            _db.OrderDetails.Update(orderDetailsFromDb);

            _db.SaveChanges();
        }
    }
}
