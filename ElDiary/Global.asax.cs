using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ElDiary
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            JsBundleConfig.Register(BundleTable.Bundles);
            CssBundleConfig.Register(BundleTable.Bundles);
        }
    }
}
