using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class HomeGuestController : Controller
    {
        public IActionResult IndexGuest()
        {
            return View();
        }
    }
}
