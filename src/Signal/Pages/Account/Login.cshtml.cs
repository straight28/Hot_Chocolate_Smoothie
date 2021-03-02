using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Signal.Data;

namespace Signal.Pages.Account
{

    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly TestDbContext _dbContext;

        public LoginModel(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public string Name { get; set; }


        [BindProperty]
        public string Password { get; set; }


        public async Task OnGet()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignOutAsync("TesterAuthentication");
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                Name = Name.Trim();
                Password = Password.Trim();

                var tester = await _dbContext.Testers.Where(t => t.Name == Name && t.Password == Password).SingleOrDefaultAsync();
                if (tester != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Sid, tester.Id.ToString()),
                        new Claim(ClaimTypes.Name, tester.Name)
                    };

                    var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var autoProperties = new AuthenticationProperties();
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity), autoProperties);
                    return RedirectToPage("/Index");

                }
                ModelState.AddModelError(string.Empty, "이름 혹은 비밀번호가 올바르지 않습니다. ");

            }
            return Page();

        }

    }
}
