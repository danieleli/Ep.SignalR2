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
            var jobs = new List<PayrollBatchJob>
            {
                new PayrollBatchJob { Description = "seed batch 1", Status = "New"}
            };

            context.PayrollBatchJobs.AddOrUpdate(x=>x.PayrollBatchJobId, jobs.ToArray());
            context.SaveChanges();

            Console.WriteLine("ends seed");
        }
    }
}
