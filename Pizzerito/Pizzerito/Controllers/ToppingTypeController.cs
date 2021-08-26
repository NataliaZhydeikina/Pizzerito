using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingTypeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public ToppingTypeController(ILogger<ToppingTypeController> logger, IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/toppingtype");
            _logger.LogInformation($"Return all ToppingTypes, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.ToppingType.GetAll().Select(topping => new ToppingType { Id = topping.Id, Name = _sharedLocalizer[topping.Name] }) });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/toppingtype/{id}");
            var objFromDb = _unitOfWork.ToppingType.GetFirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                _logger.LogError($"Error while deleting ToppingTypes with id {id}, objFromDb is null");
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.ToppingType.Remove(objFromDb);
            _unitOfWork.Save();
            _logger.LogInformation($"Delete ToppingTypes with id {id}, returning HTTP 200 - OK");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
