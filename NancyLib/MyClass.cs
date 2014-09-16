using System;
using Nancy;

namespace NancyLib
{
    public class MyModule : NancyModule
    {
        public MyModule()
        {
            Get["/"] = _ =>
            {
                throw new Exception("Oops"); 
                return 200;
            };

            Post["/"] = _ =>
            {
                throw new Exception("Oops"); 
                return 200;
            };

            Get["/ok"] = _ => 200;
        }
    }
}

