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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    Category="Action",
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
                    Category="Action",
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
                    Category="Action",
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
