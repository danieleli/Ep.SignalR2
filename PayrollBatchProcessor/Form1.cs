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
using PayrollBatchProcessor.DataServices;

namespace PayrollBatchProcessor
{
    public partial class Form1 : Form
    {
        private MessageHub _messageHub;
        private PayrollBatchService _dataService;

        public Form1()
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


            richTextBox1.Text += "Sending Started message";
            _messageHub.UpdateBatchStatus(batch.PayrollBatchId, "Started");
            richTextBox1.Text += "Updating Status\n";
            _dataService.UpdateStatus(batch.PayrollBatchId, "Started");

            richTextBox1.Text += "working\n";
            foreach (var timecard in batch.Timecards)
            {
                // simulate work
                Thread.Sleep(500);
            }

            richTextBox1.Text += "Updating Status to complete\n";
            batch.Status = "Complete";
            _dataService.Update(batch);
            richTextBox1.Text += "Sending Complete message\n";
            _messageHub.UpdateBatchStatus(batch.PayrollBatchId, "Complete");
        }
    }
}
