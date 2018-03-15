using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.Database.Models
{
    public class Message
    {
        public int Id { get; set; }

        public Friendship FriendShipID { get; set; }
        public UserProfile AuthorID { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime? SentOn { get; set; }
       
        public DateTime? SeenOn { get; set; }
    }
}
