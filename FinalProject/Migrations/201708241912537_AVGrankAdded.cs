namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AVGrankAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "AVGrank", c => c.Double(nullable: false));
            AddColumn("dbo.Ranks", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ranks", "Description", c => c.String());
            DropColumn("dbo.Ranks", "TextContent");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.Ranks", "TextContent", c => c.String());
            DropColumn("dbo.Ranks", "Description");
            DropColumn("dbo.Ranks", "Date");
            DropColumn("dbo.Businesses", "AVGrank");
        }
    }
}
