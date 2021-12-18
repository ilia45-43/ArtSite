using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Art.BackEnd.Database;
using Art.Pages.Models;
using Art.Pages.BackEnd;

namespace Art.Pages.LoginReg
{
    public class RegisterModel : PageModel
    {
        public IActionResult OnGet()
        {
            //if (HttpContext.Session.Keys.Contains("Id"))
            //{
            //    return RedirectToPage("/LoginReg/Profile");
            //}
            //else
            //{
            return Page();
            //} 

        }

        public async Task<ActionResult> OnPost(string email, string username, string password)
        {

            if (ModelState.IsValid)
            {
                var users = await MyDatabase.GetAllUsers();
                var user = users.FirstOrDefault(u => u.email == email || u.username == username);
                if (user == null)
                {
                    var currentUser = new User
                    {
                        id = Guid.NewGuid(),
                        email = email,
                        password = Encr.EncryptString(password),
                        username = username,
                    };
                    var profile = new Models.Profile()
                    {
                        Id = currentUser.id,
                    };
                    currentUser.Profile = profile;

                    await MyDatabase.Add(currentUser);
                    await MyDatabase.Add(profile);

                    HttpContext.Session.Clear();
                    HttpContext.Session.SetString("Id", currentUser.id.ToString());
                }
                else
                    ModelState.AddModelError("", $"Пользователь с такой почтой или именем пользователя  уже зарегистрирован.");
            }

            return RedirectToPage("/LoginReg/Login");
        }
    }
}