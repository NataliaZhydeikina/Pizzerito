using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzerito.Pages.Customer.Cart
{
    [Authorize]
    public class OrderConfirmationModel : PageModel
    {
        [BindProperty] // from summary post() handler id
        public int orderId { get; set; }
        public void OnGet(int id)
        {
            orderId = id;
        }
    }
}
