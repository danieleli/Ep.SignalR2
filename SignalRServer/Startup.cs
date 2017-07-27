using log4net;
using Microsoft.Owin.Cors;
using Owin;

namespace SignalRServer
{
    /// <summary>
    /// Used by OWIN's startup process. 
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            _log.Debug("Configuring SignalR");
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof(Startup));
    }

    
}
