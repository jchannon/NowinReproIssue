using System;
using Microsoft.Owin.Hosting;
using NancyLib;

namespace KatanaHTTPListenerTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://*:8081"))
            {
                Console.WriteLine("Running a http server on port 8081");
                Console.ReadKey();
            }
        }
    }
}
