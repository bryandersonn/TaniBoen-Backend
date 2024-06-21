using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaniBoen.Data;
using TaniBoen.Models;
using TaniBoen.Models.Domain;

namespace TaniBoen.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly TaniBoenData taniBoenData;

        public ShoppingCartController(TaniBoenData taniBoenData)
        {
            this.taniBoenData = taniBoenData;
        }

        /*public IActionResult ShoppingCart()
        {
            return View();
        }*/

        [HttpGet]
        public async Task<IActionResult> ShoppingCart()
        {
            var products = await taniBoenData.Product.ToListAsync();
            return View(products);
        }

        /*[HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddProductViewModel addCategoryRequest)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(),
                CategoryName = addCategoryRequest.CategoryName
            };

            await taniBoenData.Categories.AddAsync(category);
            await taniBoenData.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public async Task<IActionResult> EditCategory(Guid id)
        {
            var category = await taniBoenData.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if (category != null)
            {

                var viewModel = new UpdateCategoryViewModel()
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName
                };

                return View(viewModel);

            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(UpdateCategoryViewModel model)
        {
            var category = await taniBoenData.Categories.FindAsync(model.Id);

            if (category != null)
            {
                category.CategoryName = model.CategoryName;

                await taniBoenData.SaveChangesAsync();

                return RedirectToAction("Index");
            };

            return RedirectToAction("Index");
        }*/

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Delete(UpdateCategoryViewModel model)
        {
            var product = await taniBoenData.Product.FindAsync(model.Id);

            if (product != null)
            {
                taniBoenData.Product.Remove(product);

                await taniBoenData.SaveChangesAsync();

                return RedirectToAction("ShoppingCart");
            }

            return RedirectToAction("ShoppingCart");
        }
    }
}
