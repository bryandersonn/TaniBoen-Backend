using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}
