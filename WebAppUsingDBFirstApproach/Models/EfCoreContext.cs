using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAppUsingDBFirstApproach.Models;

public partial class EfCoreContext : DbContext
{
    public EfCoreContext()
    {
    }

    public EfCoreContext(DbContextOptions<EfCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Standard> Standards { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KDJ-LAPTOP\\SQLEXPRESS;Database=EfCore;Integrated Security=True;trustservercertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B99934A3149");

            entity.ToTable("Student");

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
