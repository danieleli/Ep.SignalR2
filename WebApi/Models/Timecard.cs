using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Timecard
    {
        public int TimecardId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public int PayrollBatchId { get; set; }

        public string EmployeeName { get; set; }
        public int TotalMinutes { get; set; }
    }
}