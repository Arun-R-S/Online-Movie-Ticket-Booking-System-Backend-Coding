using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return RedirectToAction("/movies");
        }
        public ActionResult Movies(int? movieId,int? theatreId)
        {
            if (movieId == null)
                movieId = 0;
            if (theatreId == null)
                theatreId = 0;
            return View();
        }
    }
}