using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaniBoen.Data;
using TaniBoen.Models;
using TaniBoen.Models.Domain;

namespace TaniBoen.Controllers
{
    public class ProductController : Controller
    {
        private readonly TaniBoenData taniBoenData;
        public ProductController(TaniBoenData taniBoenData)
        {
            this.taniBoenData = taniBoenData;
        }

        public IActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(UpdateCategoryViewModel product)
        {

            // Example: Storing in session
            var cart = new ProductData()
            {
                Id = Guid.NewGuid(),
                ProductName = "Kangkung",
                ProductRating = 4,
                ProductTotalReview = 10,
                ProductSold = 50,
                ProductPrice = 12000,
                ProductQuantity = 1
            };

            await taniBoenData.Product.AddAsync(cart);
            await taniBoenData.SaveChangesAsync();
            return RedirectToAction("Product");
        }
    }
}
