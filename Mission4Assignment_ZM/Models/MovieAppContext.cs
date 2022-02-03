using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4Assignment_ZM.Models
{
    public class MovieAppContext : DbContext
    {
        //contstructor
        public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options)
        {
            //leave blank for now= this is inheritance!
        }

        //responses= data set (list of data from the database)
        public DbSet<MovieAdd> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }


        //THIS IS FOR SEEDING
        protected override void OnModelCreating(ModelBuilder mb)
        {

            //This is for the Hobbies table!
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "VHS"
                }
            );

            // see if data doesn't exist
            mb.Entity<MovieAdd>().HasData(
                new MovieAdd
                {
                    Title = "Inception",
                    CategoryId = 1,
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Best Movie EVER!"
                },
                new MovieAdd
                {
                    Title = "Rudy",
                    CategoryId = 2,
                    Year = 1993,
                    Director = "David Anspaugh",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "Gave me chills"
                },
                new MovieAdd
                {
                    Title = "The Lion King",
                    CategoryId = 3,
                    Year = 1994,
                    Director = "Roger Allers",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = "SO inspirational"
                }
            );
        }
    }
}
