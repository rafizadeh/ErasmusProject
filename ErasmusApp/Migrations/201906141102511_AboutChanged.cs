namespace ErasmusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AboutChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Abouts", "BlockQuotes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "BlockQuotes", c => c.String(nullable: false));
            DropColumn("dbo.Abouts", "Title");
        }
    }
}
