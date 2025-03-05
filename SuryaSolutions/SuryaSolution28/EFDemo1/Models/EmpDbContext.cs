using EFDemo1;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCodeFirstApproach1.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmployeeModel>().HasData(
            new EmployeeModel { Id = 1, EName = "John Doe", Job = "Developer", Salary = 18000 },
          new EmployeeModel { Id = 2, EName = "Jane Smith", Job = "Trainer", Salary = 25000 }
      );
            base.OnModelCreating(builder);
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}