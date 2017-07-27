using System.Collections.Generic;

namespace PayrollBatchProcessor.Models
{
    public class PayrollBatch
    {
        public PayrollBatch()
        {
            Timecards = new List<Timecard>();
        }
        public int PayrollBatchId { get; set; }
        
        public byte[] RowVersion { get; set; }
        
        public string UserName { get; set; }
        public string BatchDesc { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Timecard> Timecards { get; set; }
    }
}