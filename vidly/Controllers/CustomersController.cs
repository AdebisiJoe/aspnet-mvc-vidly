using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowCustomers()
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

        public ActionResult ShowCustomersDetails()
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
    }
}