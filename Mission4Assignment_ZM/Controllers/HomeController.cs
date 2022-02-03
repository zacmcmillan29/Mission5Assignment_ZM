using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4Assignment_ZM.Models;

namespace Mission4Assignment_ZM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //define scope 
        private MovieAppContext blahContext { get; set; }

        //controller
        public HomeController(MovieAppContext someName)
        {
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }


        //-----CREATE -----

        [HttpGet]
        public IActionResult AddMovie()
        {
            //this returns the list of Categories
            ViewBag.Categories = blahContext.Categories.ToList();

            //var hobbies = daContext.Hobbies.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieAdd ma)
        {

            if (ModelState.IsValid)
            {
                blahContext.Add(ma);
                blahContext.SaveChanges();
                return View("Confirmation", ma);
            }
            else
            {
                //this returns the list of majors
                ViewBag.Categories = blahContext.Categories.ToList();
                return View();
            }

        }
        //----- READ -----
        [HttpGet]
        public IActionResult MovieList()
        {
            var application = blahContext.Responses
                .Include(x => x.Category)
                //.Where (blah => blah.Religious == true)
                .OrderBy(x => x.Title)
                .ToList();

            return View(application);
        }



        //----- UPDATE -----
        [HttpGet]
        public IActionResult Edit(string movie)
        {
            //this is to get the list of hobbies
            ViewBag.Categories = blahContext.Categories.ToList();

            //this is ONE of the ways to get a SINGLE record
            var application = blahContext.Responses.Single(x => x.Title == movie);

            return View("AddMovie", application);
        }

        [HttpPost]
        public IActionResult Edit(MovieAdd ma)
        {
            blahContext.Update(ma);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }



        // ----- DELETE -----
        [HttpGet]
        public IActionResult Delete(string movieDelete)
        {
            var application = blahContext.Responses.Single(x => x.Title == movieDelete);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(MovieAdd toDelete)
        {
            blahContext.Responses.Remove(toDelete);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
