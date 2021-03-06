using System;

namespace Pizzerito.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IToppingsRepository Toppings { get; }
        IToppingTypeRepository ToppingType { get; }
        IPizzaCrustTypeRepository PizzaCrustType { get; }
        IPizzaCrustFlavorRepository PizzaCrustFlavor { get; }
        IPizzaSizeRepository PizzaSize { get; }
        IPizzaTypeRepository PizzaType { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IOrderHeaderRepository OrderHeader { get; }

        void Save();
    }
}
