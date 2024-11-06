using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP03SWII6.Models;

/*
CB3011836 - Ketheleen Cristine Sim�o dos�Santos
CB3020282 - Ronald Pereira Evangelista
*/

namespace TP03SWII6.Controllers
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

        public IActionResult Creditos()
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
