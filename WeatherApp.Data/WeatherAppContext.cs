using System.Data.Entity;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class WeatherAppContext : DbContext
    {
        public WeatherAppContext()
            : base("WeatherAppDb")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Picture> Posts { get; set; }
        
    }
}
