namespace SocialNetworkWorkShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Approved = c.Boolean(nullable: false),
                        PostedOn = c.DateTime(),
                        FirstUserId_UserName = c.String(maxLength: 20),
                        SecondUserId_UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.FirstUserId_UserName)
                .ForeignKey("dbo.UserProfiles", t => t.SecondUserId_UserName)
                .Index(t => t.FirstUserId_UserName)
                .Index(t => t.SecondUserId_UserName);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 20),
                        Id = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 2),
                        LastName = c.String(maxLength: 2),
                        RegisteredOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserName)
                .Index(t => t.UserName, unique: true);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(nullable: false),
                        FileExtension = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        SentOn = c.DateTime(nullable: false),
                        SeenOn = c.DateTime(),
                        AuthorID_UserName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.AuthorID_UserName)
                .Index(t => t.AuthorID_UserName);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        PostedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "AuthorID_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "SecondUserId_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "FirstUserId_UserName", "dbo.UserProfiles");
            DropIndex("dbo.Messages", new[] { "AuthorID_UserName" });
            DropIndex("dbo.UserProfiles", new[] { "UserName" });
            DropIndex("dbo.Friendships", new[] { "SecondUserId_UserName" });
            DropIndex("dbo.Friendships", new[] { "FirstUserId_UserName" });
            DropTable("dbo.Posts");
            DropTable("dbo.Messages");
            DropTable("dbo.Images");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Friendships");
        }
    }
}
