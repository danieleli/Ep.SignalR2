using System;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PayrollBatchJob
    {
        public int PayrollBatchJobId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public string Description { get; set; }
        public string Status { get; set; }
        public string Payload { get; set; }

    }
}