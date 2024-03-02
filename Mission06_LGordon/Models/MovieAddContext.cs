using Microsoft.EntityFrameworkCore;

namespace Mission06_LGordon.Models
{
    public class MovieAddContext : DbContext // Starts as a regular old class, but have it inherit from the DbContext
                                                // It will look like an error at first. Click off and then on the light bulb and connect to the Microsoft Entity Framework Core
                                                // Liason from the app to the database
    {
        public MovieAddContext(DbContextOptions<MovieAddContext> options) : base (options) // Constructor
        { 
        }

        public DbSet<MovieAdd> Movies { get; set; } // MovieCollection will be the name of my database
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed Data - not related to the foreign key
        {
            modelBuilder.Entity<Categories>().HasData(

                new Categories { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Categories { CategoryId = 2, CategoryName = "Drama" },
                new Categories { CategoryId = 3, CategoryName = "Television" },
                new Categories { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Categories { CategoryId = 5, CategoryName = "Comedy" },
                new Categories { CategoryId = 6, CategoryName = "Family" },
                new Categories { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Categories { CategoryId = 8, CategoryName = "VHS" }

                );
        }
    }
}