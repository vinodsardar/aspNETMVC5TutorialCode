using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie()
            {
                Id = 1,
                Name = "Shrek"
            };

            Movie movie2 = new Movie()
            {
                Id = 2,
                Name = "Spider Man"
            };

            RandomViewModel rvm = new RandomViewModel();
            rvm.RandomMovies.Add(movie);
            rvm.RandomMovies.Add(movie2);

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = rvm;
            ////return View(movie);
            ////return Content("Hello Word");
            return View(rvm); ;
        } 

        public ActionResult Edit(int id)
        {
            return Content("ID : " + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if(!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    return Content(string.Format("PAge Index : {0} and sortyBy : {1}",pageIndex,sortBy));
        //}

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        [ActionName("released")]
        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(String.Format("Year {0} and Month {1}",year,month));
        }

        public ActionResult index()
        {
            MoviesViewModel movieVM = new MoviesViewModel();
            Movie movie = new Movie()
            {
                Id = 1,
                Name = "Shrek"
            };

            Movie movie2 = new Movie()
            {
                Id = 2,
                Name = "Spider Man"
            };

            movieVM.Movies.Add(movie);
            movieVM.Movies.Add(movie2);

            return View(movieVM);
        }

        public ActionResult ById(int id)
        {

            //return View();
            return Content(String.Format("ID of the movie : {0}",id));
        }
    }
}