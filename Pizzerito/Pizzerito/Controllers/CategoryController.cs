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
    public class CategoryController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public CategoryController(ILogger<CategoryController> logger,
            IUnitOfWork unitOfWork,
            IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/category");
            _logger.LogInformation($"Return all categories, returning HTTP 200 - OK");

            return Json(new
            {
                data = _unitOfWork.Category.GetAll()
                .Select(category => new Category
                {
                    Id = category.Id,
                    DisplayOrder = category.DisplayOrder,
                    Name = _sharedLocalizer[category.Name]
                })
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/category/{id}");
            var objFromDb = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            if (objFromDb == null)
            {
                _logger.LogError("Error while deleting category");
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            _logger.LogInformation($"Item {id} updated, returning HTTP 200 - OK");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
