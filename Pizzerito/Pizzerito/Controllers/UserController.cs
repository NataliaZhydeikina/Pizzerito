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
    public class UserController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation($"Enter /api/user");
            _logger.LogInformation($"Return all users, returning HTTP 200 - OK");
            return Json(new { data = _unitOfWork.ApplicationUser.GetAll() });
        }


        [HttpPost]
        public IActionResult LockUnlock([FromBody] string id)
        {
            _logger.LogInformation($"Enter /api/user/{id}");
            var objFromDb = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == id);
            bool userIsLocked = objFromDb.LockoutEnd != null && objFromDb.LockoutEnd > DateTime.Now;

            if (objFromDb == null)
            {
                _logger.LogError($"Error while locked user with id {id}, objFromDb is null, no such user");
                return Json(new { success = false, message = "Error while Locking/unlocking" });
            }
            // If user is locked
            if (userIsLocked)
            {
                objFromDb.LockoutEnd = DateTime.Now;
            }
            //If user is not locked
            else
            {
                objFromDb.LockoutEnd = DateTime.Now.AddMinutes(2);
            }
            _unitOfWork.Save();
            _logger.LogInformation($"User is lock {id}, returning HTTP 200 - OK");
            return userIsLocked ? Json(new { success = true, message = "User Unlocked Successful " })
                : Json(new { success = true, message = "User Locked Successful" });
        }

    }
}
