namespace Here.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            CreateIndex("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            CreateIndex("dbo.Customers", "MemberShipTypeId");
        }
    }
}
