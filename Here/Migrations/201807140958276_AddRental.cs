namespace Here.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DateRenturned", c => c.DateTime());
            DropColumn("dbo.Movies", "NumberAvailable");
            DropColumn("dbo.Rentals", "DateReturned");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            DropColumn("dbo.Rentals", "DateRenturned");
        }
    }
}
