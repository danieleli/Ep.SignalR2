using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class PayrollHub : Hub
    {
        private readonly Action<string> _log;

        public PayrollHub() {}

        public PayrollHub(Action<string> log)
        {
            _log = log;
        }

        public void BatchUpdated(int id, string status)
        {
            Log("Batch updated: " + id + " - " + status);
            Clients.All.batchUpdated(id, status);
        }
        public override Task OnConnected()
        {
            Log("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            Log("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }

        private void Log(string s)
        {
            _log?.Invoke(s);
        }
    }
}
