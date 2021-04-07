using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Utility;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = SD.ManagerRole)]
    public class PizzaCrustTypeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PizzaCrustTypeController(ILogger<PizzaCrustTypeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/pizzacrusttype");
            _logger.LogInformation($"Return all PizzaCrustType, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.PizzaCrustType.GetAll() });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/pizzacrusttype/{id}");
            var objFromDb = _unitOfWork.PizzaCrustType.GetFirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                _logger.LogError($"Error while deleting PizzaCrustType with id {id}");
                return Json(new { success = false, message = "Error while deleting" });
            }
                _unitOfWork.PizzaCrustType.Remove(objFromDb);
                _unitOfWork.Save();
            _logger.LogInformation($"Delete PizzaCrustType with id {id}, returning HTTP 200 - OK");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
