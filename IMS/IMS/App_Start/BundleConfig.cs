using System.Web;
using System.Web.Optimization;

namespace IMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                     "~/Scripts/jquery.min.js",
                     "~/Scripts/bootstrap.min.js",
                     "~/Scripts/jquery.navgoco.js",
                     "~/Scripts/main.js",
                     "~/Scripts/jquery.sparkline.js",
                     "~/Scripts/demo.js",
                     "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                     "~/Scripts/jquery-jvectormap/maps/world_mill_en.js",
                     "~/Scripts/d3.v3.js",
                     "~/Scripts/rickshaw.min.js",
                     "~/Scripts/jquery.flot.js",
                     "~/Scripts/jquery.flot.resize.js",
                     "~/Scripts/raphael-min.js",
                     "~/Scripts/morris.min.js",
                     "~/Scripts/dashboard.js"));

            bundles.Add(new StyleBundle("~/Content").Include(
                     "~/Content/bootstrap.min.css",
                      "~/Content/veneto-admin.min.css",
                       "~/Content/demo.css",
                        "~/Content/font-awesome.css",
                         "~/Content/jquery-jvectormap-1.2.2.css",
                          "~/Content/rickshaw.min.css",
                        "~/Content/morris.min.css"));
        }
    }
}
