using System;
using Nancy.TinyIoc;

namespace NancyLib
{
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.Owin;

    using System.Configuration;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    using System.Web;



    /// <summary>
    /// Custom Nancy bootstrapper for overriding conventions and setting up the web application
    /// </summary>
    public class VQBootstrapper : DefaultNancyBootstrapper
    {


     

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
           
            StaticConfiguration.DisableErrorTraces = false;
            StaticConfiguration.EnableRequestTracing = true;


            pipelines.OnError += (ctx, exception) =>
            {
                ctx.Items.Add("OnErrorException", exception);
                return null;
            };
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            base.RequestStartup(container, pipelines, context);

//            pipelines.BeforeRequest += (ctx) =>
//            {
//                // Add Theme to context for easier use in views
//                ctx.ViewBag.Theme = ConfigurationManager.AppSettings["Theme"];
//                ctx.ViewBag.Base = ConfigurationManager.AppSettings["Base"];
//
//                if (ctx.CurrentUser != null && ((VQUser)ctx.CurrentUser).LegacyVQUser != null)
//                {
//                    var user = (VQUser)ctx.CurrentUser;
//
//                    var sessionProvider = container.Resolve<ISessionProvider>();
//
//                    sessionProvider.Add("UserId", user.LegacyVQUser.Id);
//                }
//
//                return null;
//            };

//            container.Register<ISessionProvider, VqPortalSessionProvider>();
//
//            //We have to do this because request based dependencies are registered in a new instance of a child container with the parent also being passed in.
//            //There is no access to the child container directly so even though its passed by ref its no good so we need to register the VQSystemContainer
//            //Luckily the child container uses the parent container to resolve application wide dependencies
//            VQSystem.Container = container;

//            var owinEnvironment = context.GetOwinEnvironment();
//            if (owinEnvironment.ContainsKey("server.User"))
//            {
//                var user = owinEnvironment["server.User"] as ClaimsPrincipal;
//                if (user != null)
//                {
//                    if (user.Identity.IsAuthenticated)
//                    {
//                        var intId = int.Parse(user.Claims.FirstOrDefault(x => x.Type == "Id").Value);
//
//                        var service = container.Resolve<IUserService>();
//
//                        var vqUser = service.GetById(intId);
//
//                        vqUser.Claims = user.Claims
//                            .Where(x => x.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")
//                            .Select(x => x.Value);
//
//                        context.CurrentUser = vqUser;
//                    }
//                    else
//                    {
//                        context.CurrentUser = new VQUser
//                        {
//                            Claims = user.Claims
//                                .Where(x => x.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")
//                                .Select(x => x.Value)
//                        };
//                    }
//
//                }
//            }
        }

        //        protected override IRootPathProvider RootPathProvider
        //        {
        //            get { return new VQRootPathProvider(); }
        //        }
        //
        //        protected override Nancy.Diagnostics.DiagnosticsConfiguration DiagnosticsConfiguration
        //        {
        //            get { return new Nancy.Diagnostics.DiagnosticsConfiguration { Password = @"vqportal!" }; }
        //        }
    }
}
