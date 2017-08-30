namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class try1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        BusinessID = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(),
                        Owner = c.String(),
                        PhoneNumber = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        Website = c.String(),
                        Description = c.String(),
                        AVGrank = c.Double(nullable: false),
                        Photo = c.String(),
                        Video = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Author = c.String(),
                        Description = c.String(),
                        BusinessID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Businesses", t => t.BusinessID, cascadeDelete: true)
                .Index(t => t.BusinessID);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        OfficeID = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        HouseNumber = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Manager = c.String(),
                    })
                .PrimaryKey(t => t.OfficeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "BusinessID", "dbo.Businesses");
            DropForeignKey("dbo.Businesses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "BusinessID" });
            DropIndex("dbo.Businesses", new[] { "CategoryID" });
            DropTable("dbo.Offices");
            DropTable("dbo.Reviews");
            DropTable("dbo.Categories");
            DropTable("dbo.Businesses");
        }
    }
}
