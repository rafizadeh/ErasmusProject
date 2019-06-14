namespace ErasmusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "DesignedDescription", c => c.String());
            AddColumn("dbo.Partners", "WebSite", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Partners", "WebSite");
            DropColumn("dbo.Abouts", "DesignedDescription");
        }
    }
}
