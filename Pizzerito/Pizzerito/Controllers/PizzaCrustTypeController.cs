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
    public class PizzaCrustTypeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public PizzaCrustTypeController(ILogger<PizzaCrustTypeController> logger, IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/pizzacrusttype");
            _logger.LogInformation($"Return all PizzaCrustType, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.PizzaCrustType.GetAll().Select(pizzaCrustType => new PizzaCrustType { Id=pizzaCrustType.Id, CrustType=_sharedLocalizer[pizzaCrustType.CrustType], CrustTypeDescription=_sharedLocalizer[pizzaCrustType.CrustTypeDescription]}) });
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
