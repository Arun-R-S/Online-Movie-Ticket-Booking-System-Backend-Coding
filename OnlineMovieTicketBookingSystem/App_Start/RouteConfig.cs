using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace OnlineMovieTicketBookingSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
            name: "Booking",
            url: "booking/movies/{movieId}/{theatreId}",
            defaults: new { controller = "Booking", action = "Movies", movieId = UrlParameter.Optional,theatreId=UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "Movies",
            url: "movies/{id}",
            defaults: new { controller = "Movies", action = "Index",id=UrlParameter.Optional }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
