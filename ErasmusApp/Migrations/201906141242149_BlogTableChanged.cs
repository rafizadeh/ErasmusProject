namespace ErasmusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogTableChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "CreatedDate");
        }
    }
}
