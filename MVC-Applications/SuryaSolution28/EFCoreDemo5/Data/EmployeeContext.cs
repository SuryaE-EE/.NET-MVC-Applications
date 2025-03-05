using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EfCoreDemo05;

namespace EFCoreDemo5.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<EfCoreDemo05.EmployeeModel> EmployeeModel { get; set; } = default!;
    }
}
