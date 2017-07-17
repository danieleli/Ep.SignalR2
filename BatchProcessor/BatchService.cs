using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using BatchProcessor.DataServices;
using Timer = System.Timers.Timer;

namespace BatchProcessor
{
    public partial class BatchService : ServiceBase
    {
        private readonly PayrollBatchService _dataService;
        private Timer _timer;
        private MessageHub _messageHub;

        public BatchService()
        {
            InitializeComponent();
            _dataService = new PayrollBatchService();
            _messageHub = new MessageHub();
            SetupTimer();
        }

        private void SetupTimer()
        {
            _timer = new Timer(5000);
            _timer.Elapsed += Timer_Elapsed;
        }

        protected override void OnStart(string[] args)
        {
            _timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                _timer.Stop();
                var batch = _dataService.GetNext();
                if (batch is null) return;

                _dataService.UpdateStatus(batch.PayrollBatchId, "Started");
                _messageHub.UpdateBatchStatus(batch.PayrollBatchId, "Started");

                foreach (var timecard in batch.Timecards)
                {
                    // simulate work
                    Thread.Sleep(500);
                }
                
                batch.Status = "Complete";
                _dataService.Update(batch);
                _messageHub.UpdateBatchStatus(batch.PayrollBatchId, batch.Status);
            }
            finally
            {
                _timer.Start();
            }
            
        }
        
        protected override void OnStop()
        {
        }
    }
}
