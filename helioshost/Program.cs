using System;
using Microsoft.Owin.Hosting;
using NancyLib;

namespace helioshost
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var options = new StartOptions
            {
                ServerFactory = "Nowin",
                Port = 8080
            };

            using (WebApp.Start<Startup>(options))
            {
                Console.WriteLine("Running a http server on port 8080");
                Console.ReadKey();
            }
        }
    }
}
