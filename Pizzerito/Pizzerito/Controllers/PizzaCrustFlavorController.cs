using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Models;
using Pizzerito.Utility;
using System.Linq;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = SD.ManagerRole)]
    public class PizzaCrustFlavorController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public PizzaCrustFlavorController(ILogger<PizzaCrustFlavorController> logger, IUnitOfWork unitOfWork, IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/pizzacrustflavor");
            _logger.LogInformation($"Return all PizzaCrustFlavor, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.PizzaCrustFlavor.GetAll().Select(crustFlavor => new PizzaCrustFlavor { Id = crustFlavor.Id, CrustFlavor = _sharedLocalizer[crustFlavor.CrustFlavor], CrustFlavorDescription = _sharedLocalizer[crustFlavor.CrustFlavorDescription] }) });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/pizzacrustflavor/{id}");
            var objFromDb = _unitOfWork.PizzaCrustFlavor.GetFirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                _logger.LogError($"Error while deleting PizzaCrustFlavor with id {id}");
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.PizzaCrustFlavor.Remove(objFromDb);
            _unitOfWork.Save();
            _logger.LogInformation($"Delete PizzaCrustFlavor with id {id}, returning HTTP 200 - OK");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
