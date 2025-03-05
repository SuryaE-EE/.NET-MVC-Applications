using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using EFCoreDemo3.Models;


namespace EFCoreDemo3
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentModel>().HasData(
            new StudentModel { Id = 1, SName = "John Doe", Course = "Java", Fees = 18000 },
            new StudentModel { Id = 2, SName = "Jane Smith", Course = "Python", Fees = 25000 }
           
      );
            base.OnModelCreating(builder);
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}

