using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using TaniBoen.Data;
using TaniBoen.Models;
using TaniBoen.Models.Domain;

namespace TaniBoen.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly TaniBoenData taniBoenData;

        public CategoriesController(TaniBoenData taniBoenData)
        {
            this.taniBoenData = taniBoenData;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await taniBoenData.Categories.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddCategory(AddCategoryViewModel addCategoryRequest)
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
        }

        [HttpGet]
        public IActionResult DeleteCategory()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> DeleteCategory(UpdateCategoryViewModel model)
        {
            var category = await taniBoenData.Categories.FindAsync(model.Id);

            if (category != null)
            {
                taniBoenData.Categories.Remove(category);

                await taniBoenData.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
