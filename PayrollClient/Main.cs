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

namespace PayrollClient
{
    public partial class Main : Form
    {
        private readonly PayrollBatchService _batchService;

        public Main()
        {
            InitializeComponent();
            _batchService = new PayrollBatchService();
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
    }
}
