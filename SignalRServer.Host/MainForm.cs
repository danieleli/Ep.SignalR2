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
using log4net;
using Microsoft.Owin.Hosting;

namespace SignalRServer.Host
{
    public partial class MainForm : Form
    {
        private IDisposable _signalR;
        const string SERVER_URI = "http://localhost:8080";

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            LogMessage("Starting server...");
            StartButton.Enabled = false;

            Task.Run(() => StartServer());
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            LogMessage("Stopping server...");
            
            _signalR.Dispose();
            _signalR = null;

            StopButton.Enabled = false;
            StartButton.Enabled = true;

            LogMessage("server stopped.");
        }

        private void StartServer()
        {
            try
            {
                _signalR = WebApp.Start(SERVER_URI);
            }
            catch (TargetInvocationException)
            {
                LogMessage("Server failed to start. A server is already running on " + SERVER_URI);
                
                this.Invoke((Action)(() => StartButton.Enabled = true));
                return;
            }
            this.Invoke((Action)(() => StopButton.Enabled = true));
            LogMessage("Server started at " + SERVER_URI);
        }

        internal void LogMessage(String message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    LogMessage(message)
                ));
                return;
            }

            Log.Info(message);
            OutputTextBox.Text = message + Environment.NewLine + OutputTextBox.Text;
        }


        private static readonly ILog Log = LogManager.GetLogger(typeof(MainForm));

    }
}
