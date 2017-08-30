namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videophotodelted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Businesses", "Photo");
            DropColumn("dbo.Businesses", "Video");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "Video", c => c.String());
            AddColumn("dbo.Businesses", "Photo", c => c.String());
        }
    }
}
