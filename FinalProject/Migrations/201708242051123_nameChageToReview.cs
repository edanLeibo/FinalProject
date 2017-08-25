namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameChageToReview : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ranks", "BusinessID", "dbo.Businesses");
            DropIndex("dbo.Ranks", new[] { "BusinessID" });
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Author = c.String(),
                        Description = c.String(),
                        Score = c.Int(nullable: false),
                        BusinessID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Businesses", t => t.BusinessID, cascadeDelete: true)
                .Index(t => t.BusinessID);
            
            DropTable("dbo.Ranks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        RankID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        BusinessID = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        Author = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RankID);
            
            DropForeignKey("dbo.Reviews", "BusinessID", "dbo.Businesses");
            DropIndex("dbo.Reviews", new[] { "BusinessID" });
            DropTable("dbo.Reviews");
            CreateIndex("dbo.Ranks", "BusinessID");
            AddForeignKey("dbo.Ranks", "BusinessID", "dbo.Businesses", "BusinessID", cascadeDelete: true);
        }
    }
}
