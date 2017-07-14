using Microsoft.AspNet.SignalR.Client;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace WinFormsClient
{
    /// <summary>
    /// SignalR client hosted in a WinForms application. The client
    /// lets the user pick a user name, connect to the server asynchronously
    /// to not block the UI thread, and send chat messages to all connected 
    /// clients whether they are hosted in WinForms, WPF, or a web application.
    /// </summary>
    public partial class Form2 : Form
    {
        private SignalRBatchUpdatedListner _listner;

        internal Form2()
        {
            InitializeComponent();
            _listner = new SignalRBatchUpdatedListner();
            _listner.BatchUpdated += Listner_BatchUpdated;
            _listner.ConnectionChanged += Listner_ConnectionChanged;
            _listner.ConnectAsync();
            StatusText.Text = "Starting";

        }

        private void Listner_ConnectionChanged(object sender, EventArgs e)
        {
            var listner = (SignalRBatchUpdatedListner)sender;
            var msg = listner.IsConnected ? "Connected" : "You have been disconnected.";

            this.Invoke((Action)(() =>
            {
                StatusText.Text = msg;
            }));

        }

        private void Listner_BatchUpdated(object sender, BatchUpdatedEventArgs e)
        {
            RichTextBoxConsole.AppendText(String.Format("Batch {0}: {1}" + Environment.NewLine, e.BatchId, e.BatchStatus.ToString()));
        }


        private void WinFormsClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_listner != null)
            {
                _listner.Dispose();
            }
        }
    }
}
