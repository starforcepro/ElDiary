using System.Web.Optimization;

namespace ElDiary
{
    public class CssBundleConfig
    {
        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").IncludeDirectory("~/Content/", "*.css"));
        }
    }
}