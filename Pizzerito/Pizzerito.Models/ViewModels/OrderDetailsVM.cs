using System.Collections.Generic;

namespace Pizzerito.Models.ViewModels
{
    public class OrderDetailsVM
    {
        public OrderHeader OrderHeader { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }// list used for more than one orderdetail item 
    }
}
