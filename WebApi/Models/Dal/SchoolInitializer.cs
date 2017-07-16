using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace WebApi.Models.Dal
{
    public class SchoolInitializer :System.Data.Entity.DropCreateDatabaseIfModelChanges<PayrollContext>
    {
        protected override void Seed(PayrollContext context)
        {
            var jobs = new List<PayrollBatchJob>
            {
                new PayrollBatchJob { PayrollBatchJobId = 1, Description = "seed batch 1", Status = "New"}
            };

            context.PayrollBatchJobs.AddOrUpdate(x=>x.PayrollBatchJobId, jobs.ToArray());
        }
    }
}