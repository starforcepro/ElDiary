using System.Web.Optimization;

namespace ElDiary
{
    public class CssBundleConfig
    {
        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include(
                    "~/Content/bootstrap.css",
                    "~/Content/Site.css",
                    "~/Content/bootstrap.min.css"
                    //"~/Content/DataTables/css/jquery.dataTables.min.css",
                    //"~/Content/DataTables/css/buttons.jqueryui.min.css",
                    //"~/Content/DataTables/css/autoFill.jqueryui.min.css"
                ));
        }
    }
}