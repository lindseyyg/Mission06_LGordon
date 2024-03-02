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
                            // instance of the database
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
            ViewBag.Categories = _context.Categories.ToList(); // where it says .Categories, that could be any name. It isn't tied anywhere else
                                                               // ViewBag gets passed from the controller down to the view                                                          
            return View("MovieCollection", new MovieAdd());
        }

        [HttpPost]
        public IActionResult MovieCollection(MovieAdd response)
        {
            ViewBag.Categories = _context.Categories.ToList();

            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // add record to the database
                _context.SaveChanges(); // to save the changes

                return View("Confirmation", response);
            }
            else //invalid data
            {
                //ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }
           
        }

        public IActionResult MovieCollectionList ()
        {
            //Linq - sql-ish thing that we use to pull back a list of data
            var movieList = _context.Movies
                .Where(x => x.MovieId != null).ToList();

            return View(movieList); // passing an action to the view
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            
            ViewBag.Categories = _context.Categories.ToList();

            return View("MovieCollection", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieAdd updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            
            return RedirectToAction("MovieCollectionList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieAdd movieAdd)
        {
            _context.Movies.Remove(movieAdd);
            _context.SaveChanges();

            return RedirectToAction("MovieCollectionList");
        }
    }
}