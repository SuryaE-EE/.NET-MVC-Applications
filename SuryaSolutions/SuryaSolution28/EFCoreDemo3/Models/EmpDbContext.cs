using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using EFCoreDemo3.Models;


namespace EFCoreDemo3
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
            new EmployeeModel { Id = 2, EName = "Jane Smith", Job = "Trainer", Salary = 25000 },
            new EmployeeModel { Id =3 , EName = "Ryan Tendoscarte", Job = "Analyst", Salary = 35000},
             new EmployeeModel { Id = 4, EName = "Ryan McLaren", Job = "Analyst", Salary = 35000 },
             new EmployeeModel { Id = 5, EName = "Ryan McLaren", Job = "Analyst", Salary = 35000 }
      );
            base.OnModelCreating(builder);
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}

