namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeBatchJobs : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.PayrollBatchJobs");
        }
        
        public override void Down()
        {
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
    }
}
