namespace Here.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNickToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nick", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Nick");
        }
    }
}
