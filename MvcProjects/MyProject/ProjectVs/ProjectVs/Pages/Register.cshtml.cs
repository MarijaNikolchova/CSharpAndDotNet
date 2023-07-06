using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectVs.Data;
using ProjectVs.Models;

namespace ProjectVs.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly MyDbContext _dbContext;

        [BindProperty]
        public Users User { get; set; }

        public RegisterModel(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            // Optional: Perform any initialization logic here
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Check if the username or email already exists in the database
            if (_dbContext.Users.Any(u => u.Username == User.Username))
            {
                ModelState.AddModelError("User.Username", "Username already exists.");
                return Page();
            }

            if (_dbContext.Users.Any(u => u.Email == User.Email))
            {
                ModelState.AddModelError("User.Email", "Email already exists.");
                return Page();
            }

            // Create a new Users object
            var newUser = new Users
            {
                Username = User.Username,
                Email = User.Email,
                Password = User.Password
            };

            // Save the new user to the database
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            // Redirect to a success page or perform other actions
            return RedirectToPage("./Success");
        }
    }
}