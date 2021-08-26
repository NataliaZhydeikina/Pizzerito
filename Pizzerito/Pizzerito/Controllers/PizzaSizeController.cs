using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using Pizzerito.Utility;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = SD.ManagerRole)]
    public class PizzaSizeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public PizzaSizeController(ILogger<PizzaSizeController> logger, IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/pizzasize");
            _logger.LogInformation($"Return all PizzaSize, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.PizzaSize.GetAll().Select(pizzaSize => new PizzaSize { Id=pizzaSize.Id, Size=_sharedLocalizer[pizzaSize.Size]}) });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/pizzasize/{id}");
            var objFromDb = _unitOfWork.PizzaSize.GetFirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                _logger.LogError($"Error while deleting PizzaSize with id {id}, objFromDb is null");
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.PizzaSize.Remove(objFromDb);
            _unitOfWork.Save();
            _logger.LogInformation($"Delete PizzaSize with id {id}, returning HTTP 200 - OK");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
