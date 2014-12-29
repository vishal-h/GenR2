using GenR2.Server.Middleware;
using Owin;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web.Http;

namespace GenR2.Server
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.Use<SimpleDiagnosticsMiddleware>();
            appBuilder.UseWebApi(config);
        }
    }
}
