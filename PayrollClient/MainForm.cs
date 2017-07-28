using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollClient.DataServices;
using PayrollClient.Models;
using PayrollClient.Notifications;

namespace PayrollClient
{
    public partial class MainForm : Form
    {
        private readonly IPayrollBatchService _batchService;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IBatchUpdatedNotifier listner, IPayrollBatchService batchService) :this()
        {
            _batchService = batchService;
            listner.BatchUpdated += Listner_BatchUpdated;
        }

        private void Listner_BatchUpdated(object sender, BatchUpdatedEventArgs e)
        {
            UpdateGridItemStatus(e.BatchId, e.BatchStatus);
            
        }

        private void ButtonGetBatches_Click(object sender, EventArgs e)
        {
            var batches = _batchService.GetBatches();
            payrollBatchBindingSource.DataSource = batches;
        }

        private void ButtonSubmitBatch_Click(object sender, EventArgs e)
        {
            var rows = DataGridPayrollBatches.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                SetRowForeColor(row, Color.DarkOrange);
                var batch = (PayrollBatch)row.DataBoundItem;
                batch.Status = "Submitting...";
                this.Refresh();
                _batchService.SubmitBatch(batch.PayrollBatchId);
                Thread.Sleep(1000);
                batch.Status = "Submitted";
                SetRowForeColor(row, Color.Black);
            }
        }

        private static void SetRowForeColor(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.ForeColor = color;
                cell.Style.SelectionForeColor = color;
            }
        }


        private void UpdateGridItemStatus(int id, string status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    UpdateGridItemStatus(id, status)
                ));
                return;
            }
            var batches = (IEnumerable<PayrollBatch>)payrollBatchBindingSource.DataSource;
            
            foreach (var batch in batches)
            {
                if (batch.PayrollBatchId == id)
                {
                    batch.Status = status;
                }
            }
            DataGridPayrollBatches.Refresh();
        }
    }
}
