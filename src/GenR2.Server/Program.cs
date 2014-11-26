using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace GenR2.Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Server listening on port 9000...");
                Console.WriteLine("Press any key to close...");
                Console.ReadKey(); 
            }
        }
    }
}
