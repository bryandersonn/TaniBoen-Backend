using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class OrderHistoryController : Controller
    {
        public IActionResult OrderHistory()
        {
            return View();
        }
    }
}
