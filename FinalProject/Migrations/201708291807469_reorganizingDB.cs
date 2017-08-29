namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reorganizingDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            AddColumn("dbo.Businesses", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Businesses", "CategoryID");
            AddForeignKey("dbo.Businesses", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            DropColumn("dbo.Businesses", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "Type", c => c.String());
            DropForeignKey("dbo.Businesses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Businesses", new[] { "CategoryID" });
            DropColumn("dbo.Businesses", "CategoryID");
            DropTable("dbo.Categories");
        }
    }
}
