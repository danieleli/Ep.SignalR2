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
using PayrollClient.Models;

namespace PayrollClient
{
    public partial class Main : Form
    {
        private HttpClient _client;

        public Main()
        {
            InitializeComponent();
            _client = new HttpClient()
            {
                BaseAddress = new Uri(@"http://localhost:1765/")
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private void ButtonGetBatches_Click(object sender, EventArgs e)
        {
            var batches = GetBatches();
            payrollBatchBindingSource.DataSource = batches;
        }

        private IList<PayrollBatch> GetBatches()
        {
            var response = _client.GetAsync("api/PayrollBatches").Result;
            if (response.IsSuccessStatusCode)
            {
                var batches = response.Content.ReadAsAsync<List<PayrollBatch>>().Result;
                return batches;
            }

            return null;
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
                SubmitBatch(batch.PayrollBatchId);
                Thread.Sleep(1000);
                batch.Status = "Submitted";
                SetRowForeColor(row, Color.Black);
            }
        }

        private void SubmitBatch(int id)
        {
            var response = _client.PutAsJsonAsync($"api/ProcessPayroll/{id}",id).Result;
            if (response.IsSuccessStatusCode)
            { 
                return ;
            }
            throw new ApplicationException(response.ReasonPhrase);
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
