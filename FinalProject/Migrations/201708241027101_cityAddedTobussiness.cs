namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cityAddedTobussiness : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "StreetAddress", c => c.String());
            AddColumn("dbo.Businesses", "City", c => c.String());
            DropColumn("dbo.Businesses", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "Address", c => c.String());
            DropColumn("dbo.Businesses", "City");
            DropColumn("dbo.Businesses", "StreetAddress");
        }
    }
}
