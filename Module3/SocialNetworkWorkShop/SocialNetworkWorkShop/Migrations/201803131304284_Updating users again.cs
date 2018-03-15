namespace SocialNetworkWorkShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatingusersagain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Friendships", "FirstUserId_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "SecondUserId_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "UserProfile_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "UserProfile_UserName1", "dbo.UserProfiles");
            DropIndex("dbo.Friendships", new[] { "UserProfile_UserName" });
            DropIndex("dbo.Friendships", new[] { "UserProfile_UserName1" });
            DropIndex("dbo.Friendships", new[] { "FirstUserId_UserName" });
            DropIndex("dbo.Friendships", new[] { "SecondUserId_UserName" });
            RenameColumn(table: "dbo.Friendships", name: "UserProfile_UserName", newName: "RecieverUser_UserName");
            RenameColumn(table: "dbo.Friendships", name: "UserProfile_UserName1", newName: "SenderUser_UserName");
            AlterColumn("dbo.Friendships", "RecieverUser_UserName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Friendships", "SenderUser_UserName", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Friendships", "RecieverUser_UserName");
            CreateIndex("dbo.Friendships", "SenderUser_UserName");
            AddForeignKey("dbo.Friendships", "RecieverUser_UserName", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Friendships", "SenderUser_UserName", "dbo.UserProfiles", "UserName");
            DropColumn("dbo.Friendships", "FirstUserId_UserName");
            DropColumn("dbo.Friendships", "SecondUserId_UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Friendships", "SecondUserId_UserName", c => c.String(maxLength: 20));
            AddColumn("dbo.Friendships", "FirstUserId_UserName", c => c.String(maxLength: 20));
            DropForeignKey("dbo.Friendships", "SenderUser_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "RecieverUser_UserName", "dbo.UserProfiles");
            DropIndex("dbo.Friendships", new[] { "SenderUser_UserName" });
            DropIndex("dbo.Friendships", new[] { "RecieverUser_UserName" });
            AlterColumn("dbo.Friendships", "SenderUser_UserName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Friendships", "RecieverUser_UserName", c => c.String(maxLength: 20));
            RenameColumn(table: "dbo.Friendships", name: "SenderUser_UserName", newName: "UserProfile_UserName1");
            RenameColumn(table: "dbo.Friendships", name: "RecieverUser_UserName", newName: "UserProfile_UserName");
            CreateIndex("dbo.Friendships", "SecondUserId_UserName");
            CreateIndex("dbo.Friendships", "FirstUserId_UserName");
            CreateIndex("dbo.Friendships", "UserProfile_UserName1");
            CreateIndex("dbo.Friendships", "UserProfile_UserName");
            AddForeignKey("dbo.Friendships", "UserProfile_UserName1", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Friendships", "UserProfile_UserName", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Friendships", "SecondUserId_UserName", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Friendships", "FirstUserId_UserName", "dbo.UserProfiles", "UserName");
        }
    }
}
