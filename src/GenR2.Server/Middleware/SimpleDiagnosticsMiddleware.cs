using Microsoft.Owin;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GenR2.Server.Middleware
{
    public class SimpleDiagnosticsMiddleware : OwinMiddleware
    {
        public SimpleDiagnosticsMiddleware(OwinMiddleware next) : base(next) { }

        public async override Task Invoke(IOwinContext context)
        {
            var watch = new Stopwatch();
            watch.Start();

            await Next.Invoke(context);

            watch.Stop();
            Console.WriteLine("Request took {0} ms", watch.ElapsedMilliseconds);
        }
    }

}