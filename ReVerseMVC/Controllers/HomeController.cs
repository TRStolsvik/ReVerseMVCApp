using ReVerseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ReVerseMVC.Logic;

namespace ReVerseMVC.Controllers
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

        [HttpGet]
        public IActionResult App()
        {
            StringReverse stringRev = new();

            return View(stringRev);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult App(StringReverse input)
        {
            string output = "";
            return View(output);
        }

        public IActionResult Code()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}