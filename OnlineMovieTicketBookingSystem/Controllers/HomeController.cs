using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBookingSystem.Models;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Movies m = new Movies();
            ViewBag.Title = "Home";
            ViewBag.Movie = m.GetNewReleases();
            ViewBag.TopRated = m.GetTopRatedMovies();
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ProjectContext con = new ProjectContext();
            con.Customers.Add(customer);
            con.SaveChanges();
            
            return View();
        }
    }
}