namespace ErasmusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aboutchangeddd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "DesignedTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "DesignedTitle");
        }
    }
}
