using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FormsAuthentication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }

        public void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();

            //Alternative approach(from global filter VerifyIsEFMigrationUpToDateAttribute) to redirect to Database deployment page
            //if (EFMigrationsManagerConfig.HandleEFMigrationException(exception, Server, Response, Context))
            //    return;
        }
    }
}
