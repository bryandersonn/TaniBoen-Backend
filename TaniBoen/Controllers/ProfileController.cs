using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
