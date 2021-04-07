using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ToppingsController(ILogger<ToppingsController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/toppings");
            _logger.LogInformation($"Return all Toppings, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.Toppings.GetAll(null, null, "ToppingType") });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/toppings/{id}");
            var objFromDb = _unitOfWork.Toppings.GetFirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                _logger.LogError($"Error while deleting Toppings with id {id}, objFromDb is null");
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Toppings.Remove(objFromDb);
            _unitOfWork.Save();
            _logger.LogInformation($"Delete Toppings with id {id}, returning HTTP 200 - OK");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
