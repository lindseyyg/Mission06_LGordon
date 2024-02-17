using Microsoft.AspNetCore.Mvc;
using Mission06_LGordon.Models;
using System.Diagnostics;

namespace Mission06_LGordon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutJoel()
        {
            return View();
        }

        [HttpGet] // default
        public IActionResult MovieCollection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieCollection(MovieAdd response)
        {
            return View("Confirmation", response);
        }
    }
}
