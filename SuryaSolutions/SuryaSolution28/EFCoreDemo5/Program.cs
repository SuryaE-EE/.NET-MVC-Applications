using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EFCoreDemo5.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CourseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseContext") ?? throw new InvalidOperationException("Connection string 'CourseContext' not found.")));
builder.Services.AddDbContext<EmployeeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeContext") ?? throw new InvalidOperationException("Connection string 'EmployeeContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
