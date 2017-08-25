namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewChanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "Score");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Score", c => c.Int(nullable: false));
        }
    }
}
