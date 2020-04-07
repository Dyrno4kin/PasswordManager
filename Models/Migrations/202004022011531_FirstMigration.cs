namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameAccount = c.String(),
                        URL = c.String(),
                        LoginAccount = c.String(),
                        PasswordAccount = c.String(),
                        PasswordGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PasswordGroups", t => t.PasswordGroupId, cascadeDelete: true)
                .Index(t => t.PasswordGroupId);
            
            CreateTable(
                "dbo.PasswordGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PasswordGroups", "UserId", "dbo.Users");
            DropForeignKey("dbo.Accounts", "PasswordGroupId", "dbo.PasswordGroups");
            DropIndex("dbo.PasswordGroups", new[] { "UserId" });
            DropIndex("dbo.Accounts", new[] { "PasswordGroupId" });
            DropTable("dbo.Users");
            DropTable("dbo.PasswordGroups");
            DropTable("dbo.Accounts");
        }
    }
}
