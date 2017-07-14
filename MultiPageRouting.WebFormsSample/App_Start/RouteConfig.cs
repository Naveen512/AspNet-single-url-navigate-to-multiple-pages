using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using MultiPageRouting.WebFormsSample.App_Start;

namespace MultiPageRouting.WebFormsSample
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("DeskTopRoute", "Home", "~/DeskTopPage/Home.aspx", false, null, new RouteValueDictionary { { "IsDeskTop", new DeskTopRouteConstaint()} });
            routes.MapPageRoute("MobileRoute", "Home", "~/MobilePage/Home.aspx", false,null, new RouteValueDictionary { { "IsDeskTop", new MobileRouteConstriant() } });
        }
    }
}
