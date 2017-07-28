using System;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNet.SignalR;

namespace SignalR.Server.Hubs
{
    public class PayrollHub : Hub
    {
        private readonly IHubLogger _logger;

        public PayrollHub(IHubLogger logger)
        {
            _logger = logger;
            _logger.Log("PayrollHub Contructor");
        }

        public void BatchUpdated(int id, string status)
        {
            _logger.Log("Batch updated: " + id + " - " + status);
            Clients.All.batchUpdated(id, status);
        }

        public override Task OnConnected()
        {
            _logger.Log("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            _logger.Log("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }

    public interface IHubLogger
    {
        event EventHandler<string> MessageReceived;
        void Log(string msg);
    }

    public class HubLogger : IHubLogger
    {
        public event EventHandler<string> MessageReceived;

        public void Log(string msg)
        {
            _log.Debug(msg);
            MessageReceived?.Invoke(this, msg);
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof(HubLogger));
    }
}
