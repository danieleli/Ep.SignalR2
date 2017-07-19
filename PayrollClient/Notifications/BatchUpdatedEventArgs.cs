using System;

namespace PayrollClient.Notifications
{
    public class BatchUpdatedEventArgs : EventArgs
    {
        public int BatchId { get; set; }
        public string BatchStatus { get; set; }
    }
}