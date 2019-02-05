using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMWebsite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ACMWebsiteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ACMWebsiteContext>>()))
            {
                // Look for any movies.
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }

                context.Project.AddRange(
                    new Project
                    {
                        ProjectName = "Arudino-bot",
                        Creator = "Joseph",
                        Description = "Simple arduino project",
                        PostedDate = DateTime.Parse("2019-1-29")
                    },
                    new Project
                    {
                        ProjectName = "Garduino-bot",
                        Creator = "Cory",
                        Description = "It's a garduino, and a bot!",
                        PostedDate = DateTime.Parse("2019-03-29")
                    }


                );

                context.SaveChanges();
            }
        }
    }
}
