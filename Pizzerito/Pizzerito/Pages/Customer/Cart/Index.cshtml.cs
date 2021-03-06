using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using Pizzerito.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Pizzerito.Pages.Customer.Cart
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork _unitOfWork;

        public IndexModel(IUnitOfWork unitOfWork, ILogger<IndexModel> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        // view model to add 
        public OrderDetailsCartVM OrderDetailsCartVM { get; set; }
        public void OnGet()
        {
            OrderDetailsCartVM = new OrderDetailsCartVM()
            {
                OrderHeader = new OrderHeader(),
                ListCart = new List<ShoppingCart>()
            };

            //Initialize OrderTotal to 0;
            OrderDetailsCartVM.OrderHeader.OrderTotal = 0;

            //Retrieve shopping cart from db for the logged in user using claims from Dbase

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                //list of the shopping cart
                IEnumerable<ShoppingCart> cart = _unitOfWork.ShoppingCart.GetAll(c => c.ApplicationUserId == claim.Value);

                if (cart != null)
                {
                    OrderDetailsCartVM.ListCart = cart.ToList();
                }

                foreach (var cartList in OrderDetailsCartVM.ListCart)
                {
                    cartList.PizzaType = _unitOfWork.PizzaType.GetFirstOrDefault(m => m.Id == cartList.PizzaTypeId);
                    cartList.PizzaType.Category = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == cartList.PizzaType.CategoryId);

                    //order total 

                    OrderDetailsCartVM.OrderHeader.OrderTotal += (cartList.PizzaType.Price * cartList.Count);
                }

            }
            Message = $"Shopping card page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);

        }

        //Custom Handlers for adding, removing,  deleting cart items 
        public IActionResult OnPostPlus(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.GetFirstOrDefault(c => c.Id == cartId);
            _unitOfWork.ShoppingCart.IncrementCount(cart, 1);
            _unitOfWork.Save();
            return RedirectToPage("/Customer/Cart/Index");
        }
        public IActionResult OnPostMinus(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.GetFirstOrDefault(c => c.Id == cartId);

            if (cart.Count == 1)
            {
                _unitOfWork.ShoppingCart.Remove(cart);
                _unitOfWork.Save();
                var cnt = _unitOfWork.ShoppingCart
                    .GetAll(u => u.ApplicationUserId == cart.ApplicationUserId)
                    .ToList()
                    .Count;
                HttpContext.Session.SetInt32(SD.ShoppingCart, cnt);

            }
            else
            {
                _unitOfWork.ShoppingCart.DecrementCount(cart, 1);
                _unitOfWork.Save();

            }
            return RedirectToPage("/Customer/Cart/Index");
        }

        public IActionResult OnPostRemove(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.GetFirstOrDefault(c => c.Id == cartId);
            _unitOfWork.ShoppingCart.Remove(cart);
            _unitOfWork.Save();

            var cnt = _unitOfWork.ShoppingCart
                    .GetAll(u => u.ApplicationUserId == cart.ApplicationUserId)
                    .ToList()
                    .Count;
            HttpContext.Session.SetInt32(SD.ShoppingCart, cnt);
            return RedirectToPage("/Customer/Cart/Index");
        }
    }
}
