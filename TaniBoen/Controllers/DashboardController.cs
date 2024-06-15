using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dash()
        {
            return View();
        }
    }
}
