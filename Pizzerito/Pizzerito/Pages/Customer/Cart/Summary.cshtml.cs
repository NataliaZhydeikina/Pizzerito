using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using Pizzerito.Utility;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Pizzerito.Pages.Customer.Cart
{
    [Authorize]
    public class SummaryModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public SummaryModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // view model to add 
        [BindProperty] // bind property to make it available to the OnPost() handler
        public OrderDetailsCartVM DetailCart { get; set; }
        public IActionResult OnGet()
        {
            DetailCart = new OrderDetailsCartVM()
            {
                OrderHeader = new OrderHeader()
            };

            //Initialize OrderTotal to 0;
            DetailCart.OrderHeader.OrderTotal = 0;

            //Retrieve shopping cart from db for the logged in user using claims 

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //retrieve shopping cart
            IEnumerable<ShoppingCart> cart = _unitOfWork.ShoppingCart.GetAll(c => c.ApplicationUserId == claim.Value);

            if (cart != null)
            {
                DetailCart.ListCart = cart.ToList();
            }

            foreach (var cartList in DetailCart.ListCart)
            {
                cartList.PizzaType = _unitOfWork.PizzaType.GetFirstOrDefault(m => m.Id == cartList.PizzaTypeId);
                cartList.PizzaType.Category = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == cartList.PizzaType.CategoryId);

                //order total 

                DetailCart.OrderHeader.OrderTotal += (cartList.PizzaType.Price * cartList.Count);
            }

            ApplicationUser applicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(c => c.Id == claim.Value);
            DetailCart.OrderHeader.PickupName = applicationUser.FullName;
            DetailCart.OrderHeader.PickUpTime = DateTime.Now;
            DetailCart.OrderHeader.PhoneNumber = applicationUser.PhoneNumber;
            return Page();
        }

        // stripe payment handler 
        public IActionResult OnPost(string stripeToken)
        {
            //create OrderHeader and Order Details and add inside the database
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            // Retrieve all the items from the shopping cart 
            DetailCart.ListCart = _unitOfWork.ShoppingCart.GetAll(c => c.ApplicationUserId == claim.Value).ToList();

            //Update OrderHeader and change the PaymentStatus for the order status and payment and add Date/Time
            DetailCart.OrderHeader.PaymentStatus = SD.PaymentStatusPending;
            DetailCart.OrderHeader.OrderDate = DateTime.Now;
            DetailCart.OrderHeader.UserId = claim.Value;
            DetailCart.OrderHeader.Status = SD.PaymentStatusPending;
            DetailCart.OrderHeader.PickUpTime = Convert.ToDateTime(DetailCart
                                                                .OrderHeader
                                                                .PickUpDate
                                                                .ToShortDateString() + " " + DetailCart
                                                                .OrderHeader
                                                                .PickUpTime
                                                                .ToShortTimeString()
                                                                );
            DetailCart.OrderHeader.PhoneNumber = DetailCart.OrderHeader.PhoneNumber.Replace(" ", "")
                                        .Replace("(", "")
                                        .Replace(")", "")
                                        .Replace("-", "");

            List<OrderDetails> orderDetailslist = new List<OrderDetails>();
            _unitOfWork.OrderHeader.Add(DetailCart.OrderHeader);
            _unitOfWork.Save();

            //Loop through OrderDetails
            foreach (var item in DetailCart.ListCart)
            {
                item.PizzaType = _unitOfWork.PizzaType.GetFirstOrDefault(m => m.Id == item.PizzaTypeId);
                OrderDetails orderDetails = new OrderDetails
                {
                    PizzaTypeID = item.PizzaTypeId,
                    OrderId = DetailCart.OrderHeader.Id,
                    Description = item.PizzaType.Description,
                    Name = item.PizzaType.Name,
                    Price = item.PizzaType.Price,
                    Count = item.Count
                };
                // Modify the Order Total 

                DetailCart.OrderHeader.OrderTotal += (orderDetails.Count * orderDetails.Price);
                // add to orderDetails database 
                _unitOfWork.OrderDetails.Add(orderDetails);
            }
            //added string conversion for formating price to $0.00 
            DetailCart.OrderHeader.OrderTotal = DetailCart.OrderHeader.OrderTotal;
            // remove from cart from database using RemoveRange ref (Irepository, Repository)
            _unitOfWork.ShoppingCart.RemoveRange(DetailCart.ListCart);

            // End Session
            HttpContext.Session.SetInt32(SD.ShoppingCart, 0);
            _unitOfWork.Save();

            if (stripeToken != null)
            {
                // Charge Stripe using creditcard (Stripe Logic)
                var options = new ChargeCreateOptions
                {
                    //add amount in cents for stripe 
                    Amount = Convert.ToInt32(DetailCart.OrderHeader.OrderTotal * 100),
                    Currency = "usd",
                    Source = stripeToken, // from  IActionResult OnPost(string stripeToken) argument
                    Description = "Order ID : " + DetailCart.OrderHeader.Id, // from cart Orderheader.Id 
                };
                var service = new ChargeService();
                Charge charge = service.Create(options);

                // Log transaction ID from stripe to database 

                DetailCart.OrderHeader.TransactionId = charge.Id;

                if (charge.Status.ToLower() == "succeeded")
                {
                    // if successful send email 
                    DetailCart.OrderHeader.PaymentStatus = SD.PaymentStatusApproved;
                    DetailCart.OrderHeader.Status = SD.StatusSubmitted;
                }
                else // not successful
                {
                    DetailCart.OrderHeader.PaymentStatus = SD.PaymentStatusRejected;
                }

            }
            else // if stripeToken == null
            {
                DetailCart.OrderHeader.PaymentStatus = SD.PaymentStatusRejected;
            }
            _unitOfWork.Save();
            // when successful transaction, redirect to OrderConfirmation page 
            return RedirectToPage("/Customer/Cart/OrderConfirmation", new { id = DetailCart.OrderHeader.Id });
        }

    }
}
