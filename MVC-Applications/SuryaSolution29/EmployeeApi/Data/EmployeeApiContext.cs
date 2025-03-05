using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApi;

namespace EmployeeApi.Data
{
    public class EmployeeApiContext : DbContext
    {
        public EmployeeApiContext (DbContextOptions<EmployeeApiContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeApi.EmployeeModel> EmployeeModel { get; set; } = default!;
    }
}
