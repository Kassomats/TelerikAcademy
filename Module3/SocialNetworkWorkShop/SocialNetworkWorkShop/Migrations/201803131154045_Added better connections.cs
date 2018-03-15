namespace SocialNetworkWorkShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedbetterconnections : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostUserProfiles",
                c => new
                    {
                        Post_Id = c.Int(nullable: false),
                        UserProfile_UserName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.Post_Id, t.UserProfile_UserName })
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_UserName, cascadeDelete: true)
                .Index(t => t.Post_Id)
                .Index(t => t.UserProfile_UserName);
            
            AddColumn("dbo.Images", "UserId_UserName", c => c.String(maxLength: 20));
            AddColumn("dbo.Messages", "FriendShipID_Id", c => c.Int());
            CreateIndex("dbo.Images", "UserId_UserName");
            CreateIndex("dbo.Messages", "FriendShipID_Id");
            AddForeignKey("dbo.Images", "UserId_UserName", "dbo.UserProfiles", "UserName");
            AddForeignKey("dbo.Messages", "FriendShipID_Id", "dbo.Friendships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "FriendShipID_Id", "dbo.Friendships");
            DropForeignKey("dbo.Images", "UserId_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.PostUserProfiles", "UserProfile_UserName", "dbo.UserProfiles");
            DropForeignKey("dbo.PostUserProfiles", "Post_Id", "dbo.Posts");
            DropIndex("dbo.PostUserProfiles", new[] { "UserProfile_UserName" });
            DropIndex("dbo.PostUserProfiles", new[] { "Post_Id" });
            DropIndex("dbo.Messages", new[] { "FriendShipID_Id" });
            DropIndex("dbo.Images", new[] { "UserId_UserName" });
            DropColumn("dbo.Messages", "FriendShipID_Id");
            DropColumn("dbo.Images", "UserId_UserName");
            DropTable("dbo.PostUserProfiles");
        }
    }
}
