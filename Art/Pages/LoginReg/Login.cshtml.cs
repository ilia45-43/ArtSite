using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Art.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPostAsync([FromForm] string username, [FromForm] string password)
        {
            return Page();
        }
    }
}
