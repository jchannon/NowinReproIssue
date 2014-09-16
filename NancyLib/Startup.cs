using System;

using Owin;
using System.Threading.Tasks;

namespace NancyLib
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy(options => options.Bootstrapper = new VQBootstrapper());


        }
    }

}
