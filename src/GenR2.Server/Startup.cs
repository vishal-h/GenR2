using GenR2.Server.Middleware;
using Owin;
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
            WindsorConfig.Configure();
            config.Services.Replace(typeof(System.Web.Http.Dispatcher.IHttpControllerActivator), new WindsorCompositionRoot(WindsorConfig.Container));

            appBuilder.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            appBuilder.Use<SimpleDiagnosticsMiddleware>();
            appBuilder.UseWebApi(config);
        }

    }
}
