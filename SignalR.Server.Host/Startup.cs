using log4net;
using Microsoft.Owin.Cors;
using Owin;

namespace SignalR.Server.Host
{
    /// <summary>
    /// Used by OWIN's startup process. 
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Log.Debug("Configuring SignalR");
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }

        private static readonly ILog Log = LogManager.GetLogger(typeof(Startup));
    }

    
}
