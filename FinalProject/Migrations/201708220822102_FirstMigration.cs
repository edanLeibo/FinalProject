namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
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
                        Address = c.String(),
                        Website = c.String(),
                        TextContent = c.String(),
                        Photo = c.String(),
                        Video = c.String(),
                    })
                .PrimaryKey(t => t.BusinessID);
            
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        RankID = c.Int(nullable: false, identity: true),
                        BusinessID = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        Author = c.String(),
                        TextContent = c.String(),
                    })
                .PrimaryKey(t => t.RankID)
                .ForeignKey("dbo.Businesses", t => t.BusinessID, cascadeDelete: true)
                .Index(t => t.BusinessID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ranks", "BusinessID", "dbo.Businesses");
            DropIndex("dbo.Ranks", new[] { "BusinessID" });
            DropTable("dbo.Users");
            DropTable("dbo.Ranks");
            DropTable("dbo.Businesses");
        }
    }
}
