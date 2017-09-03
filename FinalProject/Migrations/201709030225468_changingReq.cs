namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingReq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Businesses", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Businesses", "StreetAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Businesses", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Businesses", "Website", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Businesses", "Website", c => c.String());
            AlterColumn("dbo.Businesses", "City", c => c.String());
            AlterColumn("dbo.Businesses", "StreetAddress", c => c.String());
            AlterColumn("dbo.Businesses", "PhoneNumber", c => c.String());
        }
    }
}
