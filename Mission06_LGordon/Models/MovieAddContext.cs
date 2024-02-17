using Microsoft.EntityFrameworkCore;

namespace Mission06_LGordon.Models
{
    public class MovieAddContext : DbContext // Starts as a regular old class, but have it inherit from the DbContext
                                                // It will look like an error at first. Click off and then on the light bulb and connect to the Microsoft Entity Framework Core
    {
        public MovieAddContext(DbContextOptions<MovieAddContext> options) : base (options) // Constructor
        { 
        }

        public DbSet<MovieAdd> MovieCollection { get; set; } // MovieCollection will be the name of my database
    }
}