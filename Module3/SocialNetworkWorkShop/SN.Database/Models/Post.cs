using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.Database.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        public string Content { get; set; }

        [Required]      
        public DateTime? PostedOn { get; set; }

        public Post()
        {
            this.UserProfiles = new HashSet<UserProfile>();
        }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
