using System;

namespace WinFormsClient
{
    public delegate void BatchUpdatedEventHandler(object sender, BatchUpdatedEventArgs e);

    public class BatchUpdatedListner
    {
        public event BatchUpdatedEventHandler BatchUpdated;
        
        public void UpdateBatch(int batchId, string status)
        {
            var args = new BatchUpdatedEventArgs()
            {
                BatchId = batchId,
                BatchStatus = status
            };

            OnBatchUpdated(args);
        }

        protected virtual void OnBatchUpdated(BatchUpdatedEventArgs e)
        {
            if (BatchUpdated != null)
                BatchUpdated(this, e);
        }

    }


    public class BatchUpdatedEventArgs : EventArgs
    {
        public int BatchId { get; set; }
        public string BatchStatus { get; set; }
    }
}