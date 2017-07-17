using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi.Models.Dal;

    internal sealed class Configuration : DbMigrationsConfiguration<PayrollContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PayrollContext context)
        {
            Console.WriteLine("start seed");
            var jobs = new List<PayrollBatch>
            {
                new PayrollBatch {PayrollBatchId = 1, BatchDesc = "seed batch 1", Status = "New"},
                new PayrollBatch {PayrollBatchId = 2, BatchDesc = "seed batch 2", Status = "New"},
                new PayrollBatch {PayrollBatchId = 3, BatchDesc = "seed batch 3", Status = "Done"},
                new PayrollBatch {PayrollBatchId = 4, BatchDesc = "seed batch 4", Status = "New"},
            };

            context.PayrollBatches.AddOrUpdate(x=>x.PayrollBatchId, jobs.ToArray());
            context.SaveChanges();

            Console.WriteLine("ends seed");
        }
    }
}
