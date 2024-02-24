using Microsoft.AspNetCore.Mvc;
using Mission06_LGordon.Models;
using System.Diagnostics;

namespace Mission06_LGordon.Controllers
{
    public class HomeController : Controller
    {
        private MovieAddContext _context;
        public HomeController(MovieAddContext temp) // Constructor // temp is an instance of the context, can give it whatever name we want
                                                        // As soon as the loop ends the temp will delete from memory, since it's only visible there
        { 
            _context = temp; // set temp equal to something outside of the constructor so that it has a wider scope
        }
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
            _context.MovieCollection.Add(response); // add record to the database
            _context.SaveChanges(); // to save the changes
            
            return View("Confirmation", response);
        }
    }
}