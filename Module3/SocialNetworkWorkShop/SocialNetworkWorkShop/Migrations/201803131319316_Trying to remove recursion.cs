namespace SocialNetworkWorkShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tryingtoremoverecursion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Friendships", "RecieverUser_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "SenderUser_UserName", "dbo.UserProfiles");
            AddForeignKey("dbo.Friendships", "RecieverUser_UserName", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Friendships", "SenderUser_UserName", "dbo.UserProfiles", "UserName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friendships", "SenderUser_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "RecieverUser_UserName", "dbo.UserProfiles");
            AddForeignKey("dbo.Friendships", "SenderUser_UserName", "dbo.UserProfiles", "UserName", cascadeDelete: true);
            AddForeignKey("dbo.Friendships", "RecieverUser_UserName", "dbo.UserProfiles", "UserName", cascadeDelete: true);
        }
    }
}
