using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",
                        "~/scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/content/datatables/css/datatables.bootstrap.css",
                      "~/content/typeahead.css",
                      "~/Content/toastr.css",
                      "~/Content/site.css"
                      ));
        }
    }
}
