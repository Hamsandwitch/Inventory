using System.Web;
using System.Web.Optimization;

namespace Inventory
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
                     "~/Scripts/bootstrap-switch.js",
                     "~/Scripts/bootstrap.min.js",
                     "~/Scripts/calendar-conf-events.js",
                     "~/Scripts/chartjs-conf.js",
                     "~/Scripts/common-scripts.js",
                     "~/Scripts/easy-pie-chart.js",
                     "~/Scripts/form-component.js",
                     "~/Scripts/gritter-conf.js",
                     "~/Scripts/jquery-1.8.3.min.js",
                     "~/Scripts/jquery-easy-pie-chart",
                     "~/Scripts/jquery-ui-1.9.2.custom.min.js",
                     "~/Scripts/jquery.backstretch.min.js",
                     "~/Scripts/jquery.dcjqaccordion.2.7.js",
                     "~/Scripts/jquery.js",
                     "~/Scripts/jquery.nicescroll.js",
                     "~/Scripts/jquery.scrollTo.min.js",
                     "~/Scripts/jquery.sparkline.js",
                     "~/Scripts/jquery.tagsinput.js",
                     "~/Scripts/jquery.ui.touch-punch.min.js",
                     "~/Scripts/morris-conf.js",
                     "~/Scripts/sparkline-chart.js",
                     "~/Scripts/tasks.js",
                     "~/Scripts/zabuto_calendar.js",
                     "~/Scripts/bootstrap-inputmask/bootstrap-inputmask.min.js",
                     "~/Scripts/chart-master/Chart.js",
                     "~/Scripts/fancybox/jquery.fancybox.js",
                     "~/Scripts/fullcalendar/fullcalendar.min.js",
                     "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/style-responsive.css",
                      "~/Content/style.css",
                      "~/Content/table-responsive.css",
                      "~/Content/to-do.css",
                      "~/Content/font-awesome/css/font-awesome.css",
                      "~/Content/gritter/css/jquery.gritter.css",
                      "~/Content/lineicons/style.css",
                      "~/Content/zabuto_calendar.css"));
        }
    }
}
