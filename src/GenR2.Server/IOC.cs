using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace GenR2.Server
{
    public static class WindsorConfig
    {
        public static IWindsorContainer Container = new WindsorContainer();

        public static void Configure()
        {
            Container.Register(
            Classes.FromAssemblyNamed("GenR2.DAL")
                .InNamespace("GenR2.DAL.Command")
                .WithService.DefaultInterfaces()
                .LifestyleTransient()
            );

            Container.Register(
                Types.FromAssemblyNamed("GenR2.Server")
                .BasedOn<ApiController>()
                .If(t => t.Name.EndsWith("Controller"))
                .LifestyleTransient()
            );
        }
    }

    public class WindsorCompositionRoot : IHttpControllerActivator
    {
        private readonly IWindsorContainer container;

        public WindsorCompositionRoot(IWindsorContainer container)
        {
            this.container = container;
        }

        public IHttpController Create(
            HttpRequestMessage request,
            HttpControllerDescriptor controllerDescriptor,
            Type controllerType)
        {
            var controller =
                (IHttpController)this.container.Resolve(controllerType);

            request.RegisterForDispose(
                new Release(
                    () => this.container.Release(controller)));

            return controller;
        }

        private class Release : IDisposable
        {
            private readonly Action release;

            public Release(Action release)
            {
                this.release = release;
            }

            public void Dispose()
            {
                this.release();
            }
        }
    }
}
