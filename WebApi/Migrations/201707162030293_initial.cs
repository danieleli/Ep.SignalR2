namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayrollBatches",
                c => new
                    {
                        PayrollBatchId = c.Int(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProjectId = c.Int(nullable: false),
                        UserName = c.String(),
                        AccountId = c.String(),
                        InvoiceNumber = c.String(),
                        BatchDesc = c.String(),
                    })
                .PrimaryKey(t => t.PayrollBatchId);
            
            CreateTable(
                "dbo.Timecards",
                c => new
                    {
                        TimecardId = c.Int(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        PayrollBatchId = c.Int(nullable: false),
                        EmployeeName = c.String(),
                        TotalMinutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TimecardId)
                .ForeignKey("dbo.PayrollBatches", t => t.PayrollBatchId, cascadeDelete: true)
                .Index(t => t.PayrollBatchId);
            
            CreateTable(
                "dbo.PayrollBatchJobs",
                c => new
                    {
                        PayrollBatchJobId = c.Int(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Description = c.String(),
                        Status = c.String(),
                        Payload = c.String(),
                    })
                .PrimaryKey(t => t.PayrollBatchJobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Timecards", "PayrollBatchId", "dbo.PayrollBatches");
            DropIndex("dbo.Timecards", new[] { "PayrollBatchId" });
            DropTable("dbo.PayrollBatchJobs");
            DropTable("dbo.Timecards");
            DropTable("dbo.PayrollBatches");
        }
    }
}
