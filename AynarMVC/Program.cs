using AynarMVC.DAL;
using AynarMVC.Interfaces.Repositories;
using AynarMVC.Models;
using AynarMVC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AynarMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AynarDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Ayran"));



            });

            builder.Services.AddTransient(EmployeeRepository, IBaseRepository<Employee>);
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
                   name: "areas",
                   pattern: "{area:exists}/{controller=Menu}/{action=Index}/{id?}"
                   );
            

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}