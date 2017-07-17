using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models.Dal
{
    public class PayrollContext : DbContext
    {
        public PayrollContext() : base(
            "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Payroll.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }

        public DbSet<PayrollBatchJob> PayrollBatchJobs { get; set; }
        public DbSet<PayrollBatch> PayrollBatches { get; set; }
        public DbSet<Timecard> Timecards { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}