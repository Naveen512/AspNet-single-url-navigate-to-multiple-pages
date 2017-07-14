using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MultiPageRouting.WebFormsSample.App_Start
{
    public class MobileRouteConstriant : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.Browser.IsMobileDevice;
        }
    }
}