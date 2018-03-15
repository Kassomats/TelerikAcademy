using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SN.Database.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Key]
        [Index(IsUnique = true)]
        [MaxLength(20)]
        [MinLength(4)]
        [StringLength(20,MinimumLength = 4)]
        
        public string UserName { get; set; }

        [MaxLength(2)]
        [MinLength(50)]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [MaxLength(2)]
        [MinLength(50)]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        public DateTime? RegisteredOn { get; set; }

        public UserProfile()
        {
            this.Posts = new HashSet<Post>();
        }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Friendship> FriendshipRecieved { get; set; }
        public virtual ICollection<Friendship> FriendshipSent { get; set; }
    }
}
