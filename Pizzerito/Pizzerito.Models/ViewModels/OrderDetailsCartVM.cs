using System.Collections.Generic;

namespace Pizzerito.Models
{
    public class OrderDetailsCartVM
    {
        public List<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
