using SN.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkWorkShop
{
    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext() : base("name=SocialNetwork")
        {

        }
        public virtual DbSet<Friendship> FriendShips { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>()
                        .HasMany(x => x.FriendshipSent)
                        .WithRequired(x => x.SenderUser)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfile>()
                        .HasMany(x => x.FriendshipRecieved)
                        .WithRequired(x => x.RecieverUser)
                        .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }

}
