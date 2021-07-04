using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieTicketBookingSystem.Models;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int id)
        {
            int Id = id;
            ProjectContext db = new ProjectContext();
            if (Id == 0)
                return Json(new { error = "Wrong Url" }, JsonRequestBehavior.AllowGet);
            if (db.Movies.Any(c => c.MovieId == Id))
            {
                Movies movie = new Movies();
                movie = db.Movies.Find(Id);
                ViewBag.Movie = movie;
                return View();
            }
            else
            {
                return Json(new { error = "Movie Not Found" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}