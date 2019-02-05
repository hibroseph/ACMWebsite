using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ACMWebsite.Models
{
    public class ACMWebsiteContext : DbContext
    {
        public ACMWebsiteContext (DbContextOptions<ACMWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<ACMWebsite.Models.Project> Project { get; set; }
    }
}
