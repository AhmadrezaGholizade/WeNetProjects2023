using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Project_9
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GetNearestAPI",
                routeTemplate: "api/{controller}/{action}/{x}/{y}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
