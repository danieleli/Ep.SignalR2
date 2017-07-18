using Microsoft.Owin.Hosting;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace SignalRChat
{
    /// <summary>
    /// WinForms host for a SignalR server. The host can stop and start the SignalR
    /// server, report errors when trying to start the server on a URI where a
    /// server is already being hosted, and monitor when clients connect and disconnect. 
    /// The hub used in this server is a simple echo service, and has the same 
    /// functionality as the other hubs in the SignalR Getting Started tutorials.
    /// </summary>
    public partial class MainForm : Form
    {
        private IDisposable _signalR;
        const string SERVER_URI = "http://localhost:8080";

        internal MainForm()
        {
            InitializeComponent();
        }
        
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            WriteToConsole("Starting server...");
            ButtonStart.Enabled = false;

            Task.Run(() => StartServer());
        }
        
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            //SignalR will be disposed in the FormClosing event
            Close();
        }
        
        private void StartServer()
        {
            try
            {
                _signalR = WebApp.Start(SERVER_URI);
            }
            catch (TargetInvocationException)
            {
                WriteToConsole("Server failed to start. A server is already running on " + SERVER_URI);
                //Re-enable button to let user try to start server again
                this.Invoke((Action)(() => ButtonStart.Enabled = true));
                return;
            }
            this.Invoke((Action)(() => ButtonStop.Enabled = true));
            WriteToConsole("Server started at " + SERVER_URI);
        }

        internal void WriteToConsole(String message)
        {
            if (RichTextBoxConsole.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToConsole(message)
                ));
                return;
            }
            _log.Info(message);
            RichTextBoxConsole.AppendText(message + Environment.NewLine);
        }

        private void WinFormsServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (_signalR != null)
            {
                _signalR.Dispose();
            }
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof(MainForm));
    }
}
