using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RNET104_02082024.Models;

namespace RNET104_02082024.Contexts
{
    public partial class AcademyDBContext : DbContext
    {
        public AcademyDBContext()
        {
        }

        public AcademyDBContext(DbContextOptions<AcademyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=AcademyDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.Username, "UQ__Students__536C85E4BF8C648A")
                    .IsUnique();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.HasIndex(e => e.Username, "UQ__Teacher__536C85E43B4871A9")
                    .IsUnique();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EnrollmentDate).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
