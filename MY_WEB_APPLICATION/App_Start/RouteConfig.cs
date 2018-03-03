//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Web.Mvc;
//using System.Web.Routing;

namespace MY_WEB_APPLICATION
{
	public static class RouteConfig
	{
		static RouteConfig()
		{
		}

		public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//routes.MapRoute(
			//	name: "Default",
			//	url: "{controller}/{action}/{id}",
			//	defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional }
			//);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = System.Web.Mvc.UrlParameter.Optional },
				namespaces: new[] { "MY_WEB_APPLICATION.Controllers" }
			);
		}
	}
}
