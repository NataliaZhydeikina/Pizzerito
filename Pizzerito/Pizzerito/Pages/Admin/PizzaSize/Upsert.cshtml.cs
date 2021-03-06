using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzerito.DataAccess.Data.Repository.IRepository;
using Pizzerito.Utility;

namespace Pizzerito.Pages.Admin.PizzaSize
{
    [Authorize(Roles = SD.ManagerRole)]
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Models.PizzaSize PizzaSizeObj { get; set; }


        public IActionResult OnGet(int? id)
        {
            PizzaSizeObj = new Models.PizzaSize();
            if (id != null)
            {
                PizzaSizeObj = _unitOfWork.PizzaSize.GetFirstOrDefault(p => p.Id == id);
                if (PizzaSizeObj == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (PizzaSizeObj.Id == 0)
            {
                _unitOfWork.PizzaSize.Add(PizzaSizeObj);
            }
            else
            {
                _unitOfWork.PizzaSize.Update(PizzaSizeObj);
            }
            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}
