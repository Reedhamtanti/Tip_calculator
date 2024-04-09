    using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Nineteen = 0;
            ViewBag.Fiftynine = 0;
            ViewBag.Ninetythree = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Nineteen = calc.CalculateTip(0.19);
                ViewBag.Fiftynine = calc.CalculateTip(0.59);
                ViewBag.Ninetythree = calc.CalculateTip(0.93);
            }
            else
            {
                ViewBag.Nineteen = 0;
                ViewBag.Fiftynine = 0;
                ViewBag.Ninetythree = 0;
            }
            return View(calc);
        }
    }
}
