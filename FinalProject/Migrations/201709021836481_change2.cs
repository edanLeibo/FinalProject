namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Businesses", "BusinessName", c => c.String(nullable: false));
            AlterColumn("dbo.Businesses", "Owner", c => c.String(nullable: false));
            AlterColumn("dbo.Businesses", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "Author", c => c.String(nullable: false));
            AlterColumn("dbo.Offices", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Offices", "Street", c => c.String(nullable: false));
            AlterColumn("dbo.Offices", "HouseNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Offices", "Manager", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offices", "Manager", c => c.String());
            AlterColumn("dbo.Offices", "HouseNumber", c => c.String());
            AlterColumn("dbo.Offices", "Street", c => c.String());
            AlterColumn("dbo.Offices", "City", c => c.String());
            AlterColumn("dbo.Reviews", "Author", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Businesses", "Description", c => c.String());
            AlterColumn("dbo.Businesses", "Owner", c => c.String());
            AlterColumn("dbo.Businesses", "BusinessName", c => c.String());
        }
    }
}
