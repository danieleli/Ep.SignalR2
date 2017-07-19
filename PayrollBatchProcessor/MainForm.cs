using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollBatchProcessor.DataServices;
using PayrollBatchProcessor.Models;

namespace PayrollBatchProcessor
{
    public partial class MainForm : Form
    {
        private MessageHub _messageHub;
        private PayrollBatchService _dataService;

        public MainForm()
        {
            InitializeComponent();
            _dataService = new PayrollBatchService();
            _messageHub = new MessageHub();
            _messageHub.ConnectAsync();
        }

        private void ButtonProcessNext_Click(object sender, EventArgs e)
        {
            var batch = _dataService.GetNext();
            if (batch is null) return;
            
            UpdateBatchStatus(batch.PayrollBatchId, "Processing");

            Thread.Sleep(2000);
            Log("Working...");
            foreach (var timecard in batch.Timecards)
            {
                // simulate work
                Thread.Sleep(500);
                Log("\tWorking... timecard");
            }

            UpdateBatchStatus(batch.PayrollBatchId, "Complete");
        }

        private void UpdateBatchStatus(int id, string status)
        {
            Log($"WebAoi batch ({id}) Status: {status}");
            _dataService.UpdateStatus(id, status);

            Log($"SignalR batch ({id}) Status: {status}");
            _messageHub.UpdateBatchStatus(id, status);
        }

        private void Log(string message)
        {
            _log.Info(message);
            richTextBox1.Text = message + Environment.NewLine + richTextBox1.Text;
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof(MainForm));
    }
}
