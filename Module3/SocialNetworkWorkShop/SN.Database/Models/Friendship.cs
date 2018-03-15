using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.Database.Models
{
    public class Friendship
    {
        [Key]
        public int Id { get; set; }
        public int  { get; set; }
        public int RecieverUserId { get; set; }
        public UserProfile SenderUser { get; set; }
        public UserProfile RecieverUser { get; set; }

        public bool Approved { get; set; }
        
        public DateTime? PostedOn { get; set; }


    }
}
