using Microsoft.AspNetCore.Mvc;
using ProjectVs.Data;
using ProjectVs.Models;

namespace ProjectVs.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext _dbContext;

        public UserController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Users user)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return RedirectToAction("Login", "User"); // Redirect to the login page
            }

            return View(user);
        }
    }
}