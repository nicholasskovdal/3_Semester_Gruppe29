using Krav_02.Models;
using Krav_02.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Krav_02.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult BCD()
        {
            var bcd = ProductRepository.GetAll(); 
            var bcdOnly = bcd.OfType<BCD>().ToList();
            return View(bcdOnly);
        }
        public IActionResult DivingSuit()
        {
            var divingSuit = ProductRepository.GetAll();
            var divingSuitOnly = divingSuit.OfType<DivingSuit>().ToList();
            return View(divingSuitOnly);
        }
        public IActionResult Finns()
        {
            var bcd = ProductRepository.GetAll();
            var bcdOnly = bcd.OfType<BCD>().ToList();
            return View(bcdOnly);
        }
    }
}
