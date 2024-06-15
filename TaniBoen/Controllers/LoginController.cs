using Microsoft.AspNetCore.Mvc;
using TaniBoen.Models.Domain;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TaniBoen.Models;
using TaniBoen.Data;

namespace TaniBoen.Controllers
{
    public class LoginController : Controller
    {

        private readonly TaniBoenData taniBoenData;

        public LoginController(TaniBoenData taniBoenData)
        {
            this.taniBoenData = taniBoenData;
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(LoginUserViewModel model)
        {
            var users = await taniBoenData.Users.ToListAsync();

            bool isCredentialsValid = false;
            foreach (var user in users)
            {
                if (user.Email == model.Email && user.Password == model.Password)
                {
                    isCredentialsValid = true;
                    break;
                }
            }

            if (isCredentialsValid)
            {
                return RedirectToAction("Dash", "Dashboard");
            }
            else
            {
                return View("UserLogin");
            }
        }

    }
}
