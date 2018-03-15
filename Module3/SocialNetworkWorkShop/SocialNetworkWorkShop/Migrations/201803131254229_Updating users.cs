namespace SocialNetworkWorkShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatingusers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Friendships", "UserProfile_UserName", c => c.String(maxLength: 20));
            AddColumn("dbo.Friendships", "UserProfile_UserName1", c => c.String(maxLength: 20));
            CreateIndex("dbo.Friendships", "UserProfile_UserName");
            CreateIndex("dbo.Friendships", "UserProfile_UserName1");
            AddForeignKey("dbo.Friendships", "UserProfile_UserName", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Friendships", "UserProfile_UserName1", "dbo.UserProfiles", "UserName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friendships", "UserProfile_UserName1", "dbo.UserProfiles");
            DropForeignKey("dbo.Friendships", "UserProfile_UserName", "dbo.UserProfiles");
            DropIndex("dbo.Friendships", new[] { "UserProfile_UserName1" });
            DropIndex("dbo.Friendships", new[] { "UserProfile_UserName" });
            DropColumn("dbo.Friendships", "UserProfile_UserName1");
            DropColumn("dbo.Friendships", "UserProfile_UserName");
        }
    }
}
