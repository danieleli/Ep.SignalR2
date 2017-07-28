using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollClient.Models;
using PayrollClient.UserControls;

namespace PayrollClient
{
    public partial class BatchesForm : Form
    {
        public BatchesForm()
        {
            InitializeComponent();
        }
        
        private void BatchesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = BatchesGrid.Rows[e.RowIndex];
            var selectedBatch = (PayrollBatch) selectedRow.DataBoundItem;

            foreach (TabPage t in batchDetailTabs.TabPages)
            {
                if (t.Text == selectedBatch.BatchDesc)
                {
                    batchDetailTabs.SelectedTab = t;
                    return;
                }
            }

            var tab = new TabPage(selectedBatch.BatchDesc);
            var detailControl = new BatchDetailControl();
            detailControl.SetDetails(selectedBatch);
            tab.Controls.Add(detailControl);
            detailControl.Dock = DockStyle.Fill;
            
            batchDetailTabs.TabPages.Add(tab);
            batchDetailTabs.SelectedTab = tab;

        }

        private void BatchesForm_Load(object sender, EventArgs e)
        {
            var random = new Random();
            var batches = new List<PayrollBatch>();
            for (int i = 0; i < 5; i++)
            {
                var b = new PayrollBatch()
                {
                    BatchDesc = "Batch " + i,
                    PayrollBatchId = i,
                    Status = "New",
                    UserName = "user" + i
                };
                var idStart = i * 10;
                for (int j = 0; j < 10; j++)
                {
                    var tc = new Timecard
                    {
                        PayrollBatchId = i,
                        EmployeeName = "employee " + idStart + j,
                        TotalMinutes = random.Next()
                    };
                    b.Timecards.Add(tc);
                }
                
                batches.Add(b);
            }

            payrollBatchBindingSource.DataSource = batches;
        }
    }
}
