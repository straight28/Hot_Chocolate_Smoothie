using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotChocolateSmoothie.Controllers
{
    public class AdminController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> SignIn()
        {
            return View();
        }

        public async Task<IActionResult> Signout()
        {
            return View();
        }

    }
}