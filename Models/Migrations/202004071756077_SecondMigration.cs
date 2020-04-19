namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Comment", c => c.String());
            AddColumn("dbo.Users", "Authentication", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Authentication");
            DropColumn("dbo.Accounts", "Comment");
        }
    }
}
