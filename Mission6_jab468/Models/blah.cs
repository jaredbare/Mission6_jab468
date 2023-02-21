using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jab468.Models
{
    public class blahContext: DbContext 
    {
        public blahContext (DbContextOptions<blahContext> options) : base (options)
        {

        }
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
                );
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    CategoryID = 1,
                    MovieID=1,
                    Title="Fast and Furious",
                    Year="1911",
                    DirectorFirstName="Johnny",
                    DirectorLastName="Appleseed",
                    Rating="R",
                    Edited=false,                                   
                },
                new ApplicationResponse
                {
                    CategoryID = 2,
                    MovieID=2,
                    Title="Fast and Furious 2",
                    Year="1912",
                    DirectorFirstName="Johnny",
                    DirectorLastName="Appleseed",
                    Rating="R",
                    Edited=false,                                   
                },
                new ApplicationResponse
                {
                    CategoryID = 3,
                    MovieID=3,
                    Title="Fast and Furious 3",
                    Year="1913",
                    DirectorFirstName="Johnny",
                    DirectorLastName="Appleseed",
                    Rating="R",
                    Edited=false,                                   
                }

           );
        }
    }
}
