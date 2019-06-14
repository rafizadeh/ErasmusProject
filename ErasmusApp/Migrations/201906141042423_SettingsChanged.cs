namespace ErasmusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingsChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "ShortDesc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "ShortDesc");
        }
    }
}
