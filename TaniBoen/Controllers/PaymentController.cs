using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Payment()
        {
            return View();
        }
    }
}
