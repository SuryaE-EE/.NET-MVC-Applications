using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCoreDemo5.Models;

namespace EFCoreDemo5.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext (DbContextOptions<CourseContext> options)
            : base(options)
        {
        }

        public DbSet<EFCoreDemo5.Models.CourseModel> CourseModel { get; set; } = default!;
    }
}
