using Microsoft.EntityFrameworkCore;
using System;

namespace WebAppUsingCodeFirstApproach.Models
{
    public class EfCoreContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {
        }
    }

}
   
