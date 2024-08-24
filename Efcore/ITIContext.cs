using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Efcore
{
    public class ITIContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   
            modelBuilder.Entity<Student>()
                .ToTable("Students")
                .HasKey(s => s.StudentId);

            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Course>()
                .ToTable("Courses")
                .HasKey(c => c.CourseId);

            modelBuilder.Entity<Course>()
                .Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Course>()
                .Property(c => c.Credit)
                .IsRequired();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
