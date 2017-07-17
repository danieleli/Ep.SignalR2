
namespace BatchProcessor.Models
{
    public class Timecard
    {
        public int TimecardId { get; set; }
        
        public byte[] RowVersion { get; set; }

        public int PayrollBatchId { get; set; }

        public string EmployeeName { get; set; }
        public int TotalMinutes { get; set; }
    }
}