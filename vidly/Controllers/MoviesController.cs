using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new List<Movie>()
            {
                new Movie{Id=1,Name = "Blood on the Alter"},
                new Movie {Id=2,Name= "Hello World"}
            };
            
            var customers = new List<Customer>
            {
                new Customer{Id=1,Name = "customer 1"},
                new Customer {Id=2,Name= "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ByReleasedate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies")]
        public ActionResult ShowMovies()
        {
            var movie = new List<Movie>()
            {
                new Movie{Id=1,Name = "Blood on the Alter"},
                new Movie {Id=2,Name= "Hello World"}
            };  

            var customers = new List<Customer>
            {
                new Customer{Id=1,Name = "Johnson"},
                new Customer {Id=2,Name= "Paul"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }
        [Route("movies/{id}")]
        public ActionResult MovieDetails(int Id) {
            var movie = new List<Movie>()
            {
                new Movie{Id=1,Name = "Blood on the Alter"},
                new Movie {Id=2,Name= "Hello World"}
            };

           /* movie.Find(Id);*/

            return View();
        }
    }
}