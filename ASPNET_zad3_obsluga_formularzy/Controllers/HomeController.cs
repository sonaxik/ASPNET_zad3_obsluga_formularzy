using ASPNET_zad3_obsluga_formularzy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNET_zad3_obsluga_formularzy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Rejestracja model)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", model);
            }
            else return View();
        }

        public IActionResult Wynik()
        {
            return View();
        }
    }
}
