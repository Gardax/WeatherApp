using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string AuthCode { get; set; }

        public string SessionKey { get; set; }

        public string ProfilePictureUrl { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public User()
        {
            this.Pictures = new HashSet<Picture>();
        }
    }
}
