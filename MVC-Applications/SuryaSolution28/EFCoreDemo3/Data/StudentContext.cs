using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCoreDemo3.Models;

namespace EFCoreDemo3.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentModel>().HasData(
            new StudentModel { Id = 1, SName = "John Doe", Course = "Java", Fees = 18000 },
            new StudentModel { Id = 2, SName = "Jane Smith", Course = "Python", Fees = 25000 },
            new StudentModel { Id = 5, SName = "Nithin", Course = "React", Fees = 25000 },
            new StudentModel { Id = 6, SName = "Rohit", Course = "Angular", Fees = 25000 }



      );
            base.OnModelCreating(builder);
        }

        public DbSet<EFCoreDemo3.Models.StudentModel> StudentModel { get; set; } = default!;
    }
}
