using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
