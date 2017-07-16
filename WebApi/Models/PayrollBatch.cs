using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PayrollBatch
    {
        public int PayrollBatchId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public int ProjectId { get; set; }
        public string UserName { get; set; }
        public string AccountId { get; set; }

        public string InvoiceNumber { get; set; }
        public string BatchDesc { get; set; }

        public virtual ICollection<Timecard> Timecards { get; set; }
    }
}