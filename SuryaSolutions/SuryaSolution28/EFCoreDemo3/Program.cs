using EFCoreDemo3.Models;
using EFCoreDemo3;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EFCoreDemo3.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StudentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext") ?? throw new InvalidOperationException("Connection string 'StudentContext' not found.")));
builder.Services.AddDbContext<EFCoreDemo3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EFCoreDemo3Context") ?? throw new InvalidOperationException("Connection string 'EFCoreDemo3Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
/*string cs = "server=DESKTOP-FHBRPJ7;database=EmployeeDB2;Integrated Security = True;Trust Server Certificate=True";
builder.Services.AddDbContext<EmpDbContext>(options => options.UseSqlServer(cs));*/


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
