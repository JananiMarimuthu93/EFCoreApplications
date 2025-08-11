using ConsoleAppUsingCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ConsoleBasedCodeFirstApproach.Models
{
    internal class EfCoreContext : DbContext
    {
        public DbSet<Standard> Standards { get; set; }

        public EfCoreContext(DbContextOptions<EfCoreContext> options)
            : base(options)
        {
        }

        public EfCoreContext()
        {
        }

        // No need for OnConfiguring() if you use DI to pass options
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=KDJ-LAPTOP\\SQLEXPRESS;Initial Catalog=efcore;Integrated Security=True;TrustServerCertificate=True");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Standard>(entity =>
        //    {
        //        entity.HasKey(e => e.StandardId);
        //        entity.Property(e => e.StandardId).ValueGeneratedOnAdd();
        //        entity.Property(e => e.StandardName).HasMaxLength(100);
        //        entity.Property(e => e.Description).HasMaxLength(100);

        //        // Optional seed data
        //        entity.HasData(
        //            new Standard { StandardId = 1, StandardName = "STD1", Description = "Outstanding" },
        //            new Standard { StandardId = 2, StandardName = "STD2", Description = "Good" },
        //            new Standard { StandardId = 3, StandardName = "STD3", Description = "Average" },
        //            new Standard { StandardId = 4, StandardName = "STD4", Description = "Below Average" }
        //        );
        //    });
        //}
    }
}
