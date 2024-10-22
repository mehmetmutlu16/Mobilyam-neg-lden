using Microsoft.AspNetCore.Mvc;

namespace Mobilyaminegolden.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Sepet()
        {
            return View();
        }
    }
}
