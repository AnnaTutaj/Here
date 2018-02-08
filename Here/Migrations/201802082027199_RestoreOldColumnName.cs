namespace Here.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestoreOldColumnName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            CreateIndex("dbo.Customers", "MemberShipTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            CreateIndex("dbo.Customers", "MembershipTypeId");
        }
    }
}
