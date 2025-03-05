
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sessions1.Models
{
    public class SecureDbContext: IdentityDbContext

    {
        public SecureDbContext(DbContextOptions<SecureDbContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}
