using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/angular-messages.js",
                       "~/Scripts/angular-locale_pt-br.js",
                       "~/Scripts/app.js",
                       "~/Scripts/controllers/ListaTelefonicaController.js",
                       "~/Scripts/services/contatosAPIService.js",
                       "~/Scripts/services/operadorasAPIService.js",
                       "~/Scripts/value/configValue.js",
                       "~/Scripts/services/serialGeneratorService.js",
                       "~/Scripts/services/config/serialGeneratorConfig.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/app.css"));


        }
    }
}
