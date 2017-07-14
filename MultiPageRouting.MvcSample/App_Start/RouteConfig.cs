using MultiPageRouting.MvcSample.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MultiPageRouting.MvcSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                  name: "DesktopRoute",
                  url: "{controller}/{action}/{id}",
                  defaults: new { controller = "DesktopHome", action = "Index", id = UrlParameter.Optional },
                  constraints: new { IsDesktop = new CustomRouteDeskTopConstraint() }
                );
            routes.MapRoute(
                 name: "MobileRoute",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "MobileHome", action = "Index", id = UrlParameter.Optional },
                 constraints: new { IsMobile = new CustomRouteMobileConstraint() }
               );
        }
    }
}
