using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class PayrollHub : Hub
    {
        public PayrollHub(){}

        public void BatchUpdated(int id, string status)
        {
            Program.MainForm.WriteToConsole("Batch updated: " + id + " - " + status);

            Clients.All.batchUpdated(id, status);
        }
        public override Task OnConnected()
        {
            Program.MainForm.WriteToConsole("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            Program.MainForm.WriteToConsole("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}
