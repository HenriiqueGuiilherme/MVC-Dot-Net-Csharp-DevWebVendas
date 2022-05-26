using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebsite.Models;

namespace SalesWebsite.Data
{
    public class SalesWebsiteContext : DbContext
    {
        public SalesWebsiteContext (DbContextOptions<SalesWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebsite.Models.Department> Department { get; set; }
    }
}
