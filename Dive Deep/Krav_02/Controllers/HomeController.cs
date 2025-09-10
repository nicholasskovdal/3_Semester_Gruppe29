using Microsoft.AspNetCore.Mvc;

namespace Krav_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
