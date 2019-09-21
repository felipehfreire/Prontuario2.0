using System.Web;
using System.Web.Optimization;

namespace H1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/ie").Include(
                     "~/Scripts/html5shiv.min.js",
                     "~/Scripts/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/font-awesome.min.css",
                    "~/Content/simple-line-icons.css",
                    "~/Content/animate.css",
                    "~/Content/main.css",
                    "~/Content/fullcalendar.min.css",
                    "~/Content/fullcalendar.print.css",
                    "~/content/messenger/messenger-theme-flat.css",
                    "~/content/messenger/messenger.css",
                    "~/content/select2/select2.min.css",
                    "~/content/select2/select2-bootstrap.min.css",
                    "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

         
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/plugins/pace").Include(
            "~/Scripts/plugins/pace/pace.min.js",
            "~/Scripts/plugins/fullscreen/jquery.fullscreen-min.js"));

            bundles.Add(new ScriptBundle("~/plugins/icheck").Include(
            "~/Scripts/plugins/icheck/js/icheck.min.js"));


            bundles.Add(new ScriptBundle("~/plugins/navgoco").Include(
           "~/Scripts/plugins/navgoco/jquery.navgoco.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
           "~/Scripts/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/fullcalendar").Include(
         "~/Scripts/fullcalendar.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
         "~/Scripts/moment.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/messenger").Include(
         "~/scripts/plugins/messenger/messenger-theme-flat.js",
         "~/scripts/plugins/messenger/messenger.min.js"));

            bundles.Add(new ScriptBundle("~/plugins/select2").Include(
                "~/Scripts/plugins/select2/select2.min.js"
        ));



            // Set EnableOptimizations to false for debugging. For more information,
            BundleTable.EnableOptimizations = true;
        }
    }
}
