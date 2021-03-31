using Pizzerito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
   public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
