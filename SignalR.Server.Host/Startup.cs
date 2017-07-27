using System;
using log4net;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.BuilderProperties;
using Microsoft.Owin.Cors;
using Ninject;
using Owin;
using SignalR.Server.Hubs;

namespace SignalR.Server.Host
{
    /// <summary>
    /// Used by OWIN's startup process. 
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var kernel = KernelFactory.GetKernel();
            
            Log.Debug("Configuring SignalR");
            app.UseCors(CorsOptions.AllowAll);

            var config = GetSignalRConfig(kernel);
            app.MapSignalR(config);
        }



        private static HubConfiguration GetSignalRConfig(StandardKernel kernel)
        {
            var resolver = new NinjectSignalRDependencyResolver(kernel);

            var config = new HubConfiguration()
            {
                Resolver = resolver
            };
            return config;
        }


  

        private static readonly ILog Log = LogManager.GetLogger(typeof(Startup));




    }
}
