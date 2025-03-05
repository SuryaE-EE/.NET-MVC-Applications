using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sessions1.Models;

namespace Sessions1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string? cs1 = builder.Configuration.GetConnectionString("cs1");


            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                       .AddEntityFrameworkStores<SecureDbContext>();

            builder.Services.AddDbContext<SecureDbContext>(options => options.UseSqlServer(cs1));

            builder.Services.AddSession(options => options.IdleTimeout = TimeSpan.FromSeconds(180));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
