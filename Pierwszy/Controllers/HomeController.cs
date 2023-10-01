using Microsoft.AspNetCore.Mvc;
using Pierwszy.Models;
using System.Diagnostics;

namespace Pierwszy.Controllers
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

        public IActionResult About()
        {
            ViewBag.Name = "Anna";
            ViewBag.godzina = DateTime.Now.Hour;
            ViewBag.powitanie = ViewBag.godzina < 17 ? "Dzień dobry" : "Dobry Wieczór!";

            Dane[] osoby =
            {
                new Dane{Name = "Anna", Surname = "Nowak"},
                new Dane{Name = "Jan", Surname = "Nowak"},
                new Dane{Name = "Mateusz", Surname = "Kowalski"},
            };
            return View();
        }

        public IActionResult UrodzinyForm()
        {
            return View();
        }

        public IActionResult Urodziny(Urodziny urodziny)
        {
            ViewBag.powitanie = $"Witaj {urodziny.Imie} {DateTime.Now.Year - urodziny.Rok}";
            return View(urodziny);
        }

        public IActionResult Kalkulator(Kalkulator kalkulator)
        {

            return View(kalkulator);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}