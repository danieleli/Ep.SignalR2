using System.Data.Entity;

namespace SignalRServer.Models
{
    public class BatchContext : DbContext
    {
        public IDbSet<Batch> Batches { get; set; }
    }

    public class Batch
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
