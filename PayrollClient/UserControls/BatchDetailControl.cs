using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollClient.Models;

namespace PayrollClient.UserControls
{
    public partial class BatchDetailControl : UserControl
    {
        private bool _webServiceBusy = false;

        public BatchDetailControl()
        {
            InitializeComponent();
        }

        public void SetDetails(PayrollBatch batch)
        {
            this.dataGridView2.DataSource = batch.Timecards;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(7*1000);
        }

        private void FinalizeButton_Click(object sender, EventArgs e)
        {
            DisableForm();
            progressBar1.Visible = true;

            Task.Run(() =>
            {
                CallWebService();
                EnableForm();
            });

            UpdateProgress();

        }


        private void CallWebService()
        {
            _webServiceBusy = true;
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
            }
            _webServiceBusy = false;
        }

        private void UpdateProgress()
        {
            Task.Run(() =>
            {
                while (_webServiceBusy)
                {
                    this.Invoke((Action) (() =>
                    {
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
                    }));
                    Thread.Sleep(1000);
                }
            });
        }

        private void DisableForm()
        {
            this.Enabled = false;  
        }

        private void EnableForm()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => EnableForm()));
                return;
            }

            this.Enabled = true;
            progressBar1.Visible = false;
            progressBar1.Value = 0;
           
        }


    }
}
