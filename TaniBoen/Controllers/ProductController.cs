using Microsoft.AspNetCore.Mvc;

namespace TaniBoen.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
