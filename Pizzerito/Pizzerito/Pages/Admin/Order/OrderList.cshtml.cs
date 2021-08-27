using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzerito.Pages.Admin.Order
{
    [Authorize]
    public class OrderListModel : PageModel
    {

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
