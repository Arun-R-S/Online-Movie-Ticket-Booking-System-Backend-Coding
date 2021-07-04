using System.Web;
using System.Web.Optimization;

namespace OnlineMovieTicketBookingSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new StyleBundle("~/Style/lib").Include(
                      "~/Content/DataTables/css/dataTables.bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js")); 

            bundles.Add(new ScriptBundle("~/bundles/jquerycsharp").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new ScriptBundle("~/Script/bookingpage").Include(
                      "~/Scripts/booking.js"));

            bundles.Add(new ScriptBundle("~/Script/mainpage").Include(
                      "~/Scripts/main.js",
                      "~/Scripts/navbar.js"));

            bundles.Add(new StyleBundle("~/Style/mainpage").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/compact_util.css",
                      "~/Content/material-icon-outlined.css",
                      "~/Content/styles.css"));

            bundles.Add(new StyleBundle("~/Style/adminindex").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/compact_util.css",
                      "~/AdminContent/css/admin-style.css"));

            bundles.Add(new ScriptBundle("~/Script/adminindex").Include(
                      "~/AdminContent/script/main.js",
                      "~/AdminContent/script/progress-bar.js"
                      ));

            bundles.Add(new StyleBundle("~/Style/adminpage").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/compact_util.css",
                      "~/Content/material-icon-outlined.css",
                      "~/Content/styles.css",
                      "~/Content/admin.css"));

            bundles.Add(new StyleBundle("~/Style/bookingpage").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/booking.css",
                      "~/Content/compact_util.css",
                      "~/Content/material-icon-outlined.css",
                      "~/Content/styles.css"));
        }
    }
}
