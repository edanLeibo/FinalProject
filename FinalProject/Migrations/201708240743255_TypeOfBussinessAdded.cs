namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeOfBussinessAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "Type", c => c.String());
            AddColumn("dbo.Businesses", "Description", c => c.String());
            DropColumn("dbo.Businesses", "TextContent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "TextContent", c => c.String());
            DropColumn("dbo.Businesses", "Description");
            DropColumn("dbo.Businesses", "Type");
        }
    }
}
