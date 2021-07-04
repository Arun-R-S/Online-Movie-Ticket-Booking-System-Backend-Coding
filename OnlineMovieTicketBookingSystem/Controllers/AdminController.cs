using OnlineMovieTicketBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace OnlineMovieTicketBookingSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string adminId,string Password)
        {
            //return Content(String.Format());
            if (adminId.Equals("RSA123"))
            {
                if (Password.Equals("1234"))
                {

                    HttpCookie cookie = new HttpCookie("admin", "Arun R S");
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                    //return Content(adminId + " " + Password + " Yes");
                    return RedirectToAction("");
                }
            }
            return RedirectToAction("login", "admin", new { @error = "Wrong Credential!" });
        }
        public ActionResult Logout()
        {
            var c = new HttpCookie("admin");
            c.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(c);
            return RedirectToAction("");
        }
        public ActionResult ViewMovies()
        {
            Movies m = new Movies();
            ViewBag.Title = "Home";
            
            ViewBag.Movie = m.GetAllMovies();

            return View();
        }
        public ActionResult NewMovieEntry()
        {
            return View();
        }

        public ActionResult UpdateMovie(int id)
        {
            ProjectContext db = new ProjectContext();
            var model = db.Movies.Find(id);
            return View(model);
        }
        
        [HttpPost]
        public ActionResult ImageUpload(Movies movie)
        {
            Object obj;
            if (Request.Form["MovieName"] == "")
                return Json(new { result = false, message = "Movie Name is must" });
            if (Request.Form["Genre"] == "")
                return Json(new { result = false, message = "Genre is must" });
            
            try
            {
                ProjectContext db = new ProjectContext();
                var file = Request.Files["ImageFile"];
                movie.MovieName = Request.Form["MovieName"];
                if(db.Movies.Any(c=> c.MovieName==movie.MovieName))
                {
                    obj = new { result = false, message = "Movie Name Already found!" };
                    return Json(obj);
                }

                movie.ReleaseDate = Convert.ToDateTime(Request.Form["ReleaseDate"]).Date;

                movie.Genre = Request.Form["Genre"];

                byte[] Imagebyte = null;
                
                BinaryReader reader = new BinaryReader(file.InputStream);
                Imagebyte = reader.ReadBytes(file.ContentLength);
                db.Movies.Add(movie);
                db.SaveChanges();
                movie.PosterImage = movie.MovieId + "." + movie.MovieName + System.IO.Path.GetExtension(file.FileName);
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                file.SaveAs(Server.MapPath("/UploadFiles/" + movie.MovieId+"."+movie.MovieName + System.IO.Path.GetExtension(file.FileName)));
                PosterImageData po = new PosterImageData();
                po.MovieId = movie.MovieId;
                po.PosterData = Imagebyte;
                db.PosterImageDatas.Add(po);
                db.SaveChanges();
                obj = new { result=true, message="New Movie Details Inserted"};
            }
            catch
            {
                obj = new { result = false, message = "Internal Error! Movie not inserted" };
            }
            return Json(obj);
        }
        public ActionResult DisplayingImage(int id)
        {
            ProjectContext con = new ProjectContext();
            var img = con.Movies.SingleOrDefault(x => x.MovieId==id);
            return File(img.PosterImage, "image/jpg");
        }
    }
}