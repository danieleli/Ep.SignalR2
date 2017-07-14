using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace SignalRChat
{
    public class BatchUpdatedHub : Hub
    {
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
        public override Task OnDisconnected()
        {
            Program.MainForm.WriteToConsole("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected();
        }
    }
}
