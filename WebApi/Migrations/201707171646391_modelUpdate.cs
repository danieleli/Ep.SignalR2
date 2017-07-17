namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PayrollBatches", "Status", c => c.String());
            DropColumn("dbo.PayrollBatches", "ProjectId");
            DropColumn("dbo.PayrollBatches", "AccountId");
            DropColumn("dbo.PayrollBatches", "InvoiceNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PayrollBatches", "InvoiceNumber", c => c.String());
            AddColumn("dbo.PayrollBatches", "AccountId", c => c.String());
            AddColumn("dbo.PayrollBatches", "ProjectId", c => c.Int(nullable: false));
            DropColumn("dbo.PayrollBatches", "Status");
        }
    }
}
