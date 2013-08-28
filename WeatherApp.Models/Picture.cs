using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public User User { get; set; }

    }
}
