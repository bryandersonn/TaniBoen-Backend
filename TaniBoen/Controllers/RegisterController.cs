using Microsoft.AspNetCore.Mvc;
using TaniBoen.Data;
using TaniBoen.Models;
using TaniBoen.Models.Domain;

namespace TaniBoen.Controllers
{
    public class RegisterController : Controller
    {
        private readonly TaniBoenData taniBoenData;

        public RegisterController(TaniBoenData taniBoenData)
        {
            this.taniBoenData = taniBoenData;
        }

        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(AddRegisterViewModel AddUserRequest)
        {
            var user = new RegisData()
            {
                Id = Guid.NewGuid(),
                Name = AddUserRequest.Name,
                Email = AddUserRequest.Email,
                Password = AddUserRequest.Password,
                PhoneNumber = AddUserRequest.PhoneNumber
            };

            await taniBoenData.Register.AddAsync(user);
            await taniBoenData.SaveChangesAsync();
            return RedirectToAction("UserRegister");
        }
    }
}
