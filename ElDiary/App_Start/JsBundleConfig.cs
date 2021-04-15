using System.Web.Optimization;

namespace ElDiary
{
    public class JsBundleConfig
    {
        public static void Register(BundleCollection bundles)
        {
            bundles
                .Add(new ScriptBundle("~/Bundle/Scripts/Layout")
                    .Include("~/scripts/jquery-3.1.1.min.js",
                        "~/scripts/bootstrap.min.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/jquery.validate-vsdoc.js",
                        "~/scripts/jquery.validate.js",
                        "~/scripts/jquery.validate.unobtrusive.js"));
        }
    }
}