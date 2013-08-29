using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AngularWithPartialViewViews
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
          name: "Partials",
          url: "partials/{action}",
          defaults: new { controller = "Partials", action = "Empty" }
      );
      routes.MapRoute(
          name: "Default",
          url: "{*catchAll}",
          defaults: new { controller = "Default", action = "Main", catchAll = UrlParameter.Optional }
      );
    }
  }
}