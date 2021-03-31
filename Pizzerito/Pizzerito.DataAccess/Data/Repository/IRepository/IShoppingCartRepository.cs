using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        //Define variables for Incrementing and Decromenting Counter 
        int IncrementCount(ShoppingCart shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);
    }
}
