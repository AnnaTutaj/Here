namespace Here.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            CreateIndex("dbo.Customers", "MembershipTypeId");

            RenameColumn("dbo.Customers", "MemberShipTypeId", "MembershipTypeId");

        }

        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            CreateIndex("dbo.Customers", "MemberShipTypeId");

            RenameColumn("dbo.Customers", "MembershipTypeId", "MemberShipTypeId");

        }
    }
}
