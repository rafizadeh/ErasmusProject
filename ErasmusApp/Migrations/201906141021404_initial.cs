namespace ErasmusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        ShortDesc = c.String(nullable: false),
                        BlockQuotes = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Photo = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Password = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ShortDesc = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Photo = c.String(nullable: false),
                        Slug = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        SendDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GalleryPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GalleryId = c.Int(nullable: false),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Galleries", t => t.GalleryId, cascadeDelete: true)
                .Index(t => t.GalleryId);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Photo = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Facebook = c.String(nullable: false),
                        Twitter = c.String(nullable: false),
                        Lat = c.String(nullable: false),
                        Lang = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GalleryPhotoes", "GalleryId", "dbo.Galleries");
            DropIndex("dbo.GalleryPhotoes", new[] { "GalleryId" });
            DropTable("dbo.Settings");
            DropTable("dbo.Partners");
            DropTable("dbo.GalleryPhotoes");
            DropTable("dbo.Galleries");
            DropTable("dbo.Contacts");
            DropTable("dbo.Blogs");
            DropTable("dbo.Admins");
            DropTable("dbo.Activities");
            DropTable("dbo.Abouts");
        }
    }
}
