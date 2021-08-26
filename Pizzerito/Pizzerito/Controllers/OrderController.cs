using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using Pizzerito.Models.ViewModels;
using Pizzerito.Utility;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller 
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(ILogger<OrderController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        //Updated to get data from OrderList page for Cancelled, Completed, or Inprocessed orders 
        [HttpGet]
        [Authorize]
        public  IActionResult Get(string status = null,DateTime startDate = new DateTime(), DateTime endDate = new DateTime())
        {
            _logger.LogInformation($"Enter /api/order");
            List<OrderDetailsVM> orderListVM = new List<OrderDetailsVM>();

            IEnumerable<OrderHeader> OrderHeaderList;

            if (User.IsInRole(SD.CustomerRole))
            {
                // retrieve all order for the logged in customer from database
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                // get info from single customer and display ApplicationUser properties 
                OrderHeaderList = _unitOfWork.OrderHeader.GetAll(u => u.UserId == claim.Value, null, "ApplicationUser");
            }
            else
            {
                //If not customer retrieve all the orders 
                OrderHeaderList = _unitOfWork.OrderHeader.GetAll(null, null, "ApplicationUser");
            }

            //Added to get data from OrderList page for Cancelled, Completed, or Inprocessed orders 
            if (status == "cancelled")
            {
                _logger.LogInformation($"Find all cancelled, refund or rejected orders");
                OrderHeaderList = OrderHeaderList.Where(o => o.Status == SD.StatusCancelled 
                                                        || o.Status == SD.StatusRefunded
                                                        || o.Status == SD.PaymentStatusRejected);
            }
            else
            {
                if (status == "completed")
                {
                    _logger.LogInformation($"Find all completed orders");
                    OrderHeaderList = OrderHeaderList.Where(o => o.Status == SD.StatusCompleted);
                }
                else
                {
                    _logger.LogInformation($"Find all ready, in progress submitted or payment pending orders");
                    OrderHeaderList = OrderHeaderList.Where(o => o.Status == SD.StatusReady 
                                                                || o.Status == SD.StatusInProcess 
                                                                || o.Status == SD.StatusSubmitted
                                                                || o.Status == SD.PaymentStatusPending);
                }
            }
            _logger.LogInformation($"Fiter orders by date: start-{startDate}, end-{endDate}");
            OrderHeaderList = OrderHeaderList.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate);
            foreach (OrderHeader item in OrderHeaderList)
            {
                OrderDetailsVM individual = new OrderDetailsVM
                {
                    // assign order header 
                    OrderHeader = item,
                    // retrieve from DataBase
                    OrderDetails = _unitOfWork.OrderDetails.GetAll(o => o.OrderId == item.Id).ToList()
                };
            // Add to orderListVM
            orderListVM.Add(individual);
            }

            _logger.LogInformation($"Return all orders, returning HTTP 200 - OK");
            return Json(new { data = orderListVM });
        }
    }
}
