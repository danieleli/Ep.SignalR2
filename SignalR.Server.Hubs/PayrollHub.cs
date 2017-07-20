using System.Threading.Tasks;
using log4net;
using Microsoft.AspNet.SignalR;

namespace SignalR.Server.Hubs
{
    public class PayrollHub : Hub
    {
        public void BatchUpdated(int id, string status)
        {
            Log.Info("Batch updated: " + id + " - " + status);
            Clients.All.batchUpdated(id, status);
        }
        public override Task OnConnected()
        {
            Log.Info("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            Log.Info("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
        
        private static readonly ILog Log = LogManager.GetLogger(typeof(PayrollHub));
    }
}
