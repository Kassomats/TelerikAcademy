using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.Database.Models
{
    public class Image
    {
        public UserProfile UserId { get; set; }
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string FileExtension { get; set; }
    }
}
