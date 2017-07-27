using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRServer.Hubs
{
    /// <summary>
    /// Echoes messages sent using the Send message by calling the
    /// addMessage method on the client. Also reports to the console
    /// when clients connect and disconnect.
    /// </summary>
    public class MyHub : Hub
    {
        public void Send(string name, string message)
        {
            Program.MainForm.WriteToConsole(string.Format("{0}: {1}", name, message));
            Clients.All.addMessage(name, message);
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
