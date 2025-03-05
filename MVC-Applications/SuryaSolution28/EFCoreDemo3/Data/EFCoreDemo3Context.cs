using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCoreDemo3.Models;

namespace EFCoreDemo3.Data
{
    public class EFCoreDemo3Context : DbContext
    {
        public EFCoreDemo3Context (DbContextOptions<EFCoreDemo3Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmployeeModel>();
            new EmployeeModel { Id = 9, EName = "Dumminy", Job = "Developer", Salary = 18000 };
            new EmployeeModel { Id = 10, EName = "Dale", Job = "Trainer", Salary = 25000 };


      
            base.OnModelCreating(builder);
        }
        public DbSet<EmployeeModel> EmployeeModel { get; set; } = default!;
    }
}
