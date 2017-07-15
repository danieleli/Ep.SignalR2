using Microsoft.Owin.Hosting;
using SignalRChat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRChat
{
    public class GetUnfinishedBatchesCommand
    {
        private BatchContext _db;

        public GetUnfinishedBatchesCommand(BatchContext db)
        {
            _db = db;
        }

        public IEnumerable<Batch> Excute()
        {
            return null;
        }
    }
    public partial class BatchUpdateServer : Form
    {
        private IDisposable _signalR;
        const string ServerURI = "http://localhost:8080";

        public BatchUpdateServer()
        {
            InitializeComponent();
        }

        private void _buttonStartHub_Click(object sender, EventArgs e)
        {
            WriteToConsole("Starting server...");
            
            _buttonStartHub.Enabled = false;
            Task.Run(() => StartServer());
        }

        private void StartServer()
        {
            try
            {
                _signalR = WebApp.Start(ServerURI);
            }
            catch (TargetInvocationException)
            {
                WriteToConsole("Server failed to start. A server is already running on " + ServerURI);
                //Re-enable button to let user try to start server again
                this.Invoke((Action)(() => _buttonStartHub.Enabled = true));
                return;
            }
            this.Invoke((Action)(() => _buttonStartHub.Enabled = true));
            WriteToConsole("Server started at " + ServerURI);
        }

        internal void WriteToConsole(String message)
        {
            
            if (_textboxConsole.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToConsole(message)
                ));
                return;
            }
            _textboxConsole.AppendText(message + Environment.NewLine);
        }
    }
}
