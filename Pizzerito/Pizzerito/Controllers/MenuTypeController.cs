using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizzerito.DataAccess.Data.Repository.IRepository;

namespace Pizzerito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTypeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;
        //Will be deleting images from server
        private readonly IWebHostEnvironment _hostingEnvironment;

        public MenuTypeController(ILogger<CategoryController> logger, IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/menutype");
            _logger.LogInformation($"Return menu types, returning HTTP 200 - OK");
            return Json(new
            {
                data = _unitOfWork.PizzaType
                .GetAll(null, null, "Category,ToppingType,PizzaCrustType,PizzaCrustFlavor,PizzaSize")
            });

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Enter /api/menutype/{id}");
            try
            {
                var objFromDb = _unitOfWork.PizzaType.GetFirstOrDefault(p => p.Id == id);
                if (objFromDb == null)
                {
                    _logger.LogError($"Error while deleting menu type, no such object, id {id}");
                    return Json(new { success = false, message = "Error while deleting" });
                }

                //check if image is in root 
                var imagePath = Path.Combine(_hostingEnvironment.WebRootPath, objFromDb.Image.TrimStart('\\'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
                _unitOfWork.PizzaType.Remove(objFromDb);
                _unitOfWork.Save();
                _logger.LogInformation($"Delete image from root");
            }
            catch (Exception ex)
            { 
                _logger.LogError($"Error while deleting menu type, {ex.Message} {ex.Data}");
                return Json(new { success = true, message = "Error while deleting" });
            }
            _logger.LogInformation($"Delete successful");
            return Json(new { success = true, message = "Delete successful" });
        }

    }
}
