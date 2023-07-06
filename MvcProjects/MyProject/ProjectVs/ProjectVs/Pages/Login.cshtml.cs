using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using ProjectVs.Data;
using ProjectVs.Models;

namespace ProjectVs.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserRepository _userRepository;

        [BindProperty]
        public Users Users { get; set; }

        public string ErrorMessage { get; set; }

        public LoginModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                Users existingUser = _userRepository.GetUserByUsername(Users.Username);
                if (existingUser == null || existingUser.Password != Users.Password)
                {
                    ErrorMessage = "Invalid username or password.";
                    return Page();
                }

                Task.Delay(TimeSpan.FromSeconds(5)).Wait();

                TempData["SuccessMessage"] = "Login successful!";
                return Redirect("/index.html");
            }

            return Page();
        }
    }
}