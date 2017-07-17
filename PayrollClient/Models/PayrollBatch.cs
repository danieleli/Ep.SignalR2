using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayrollClient.Models
{
    public class PayrollBatch
    {
        public PayrollBatch()
        {
            Timecards = new List<Timecard>();
        }
        public int PayrollBatchId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        
        public string UserName { get; set; }
        public string BatchDesc { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Timecard> Timecards { get; set; }
    }
}