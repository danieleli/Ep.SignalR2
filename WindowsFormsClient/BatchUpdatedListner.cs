using System;

namespace WinFormsClient
{
    public delegate void BatchUpdatedEventHandler(object sender, BatchUpdatedEventArgs e);

    public class BatchUpdatedEventArgs : EventArgs
    {
        public int BatchId { get; set; }
        public string BatchStatus { get; set; }
    }

    public class BatchUpdatedListner
    {
        public event BatchUpdatedEventHandler BatchUpdated;
        
        protected void UpdateBatch(int batchId, string status)
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
            BatchUpdated?.Invoke(this, e);
        }

    }



}