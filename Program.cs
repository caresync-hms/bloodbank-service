

using BloodBankService.Models;
using Microsoft.EntityFrameworkCore;

namespace BloodBankService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BloodDbContext>(options =>
            options.UseSqlServer("DefaultConnection": "Server=sqlserver,1433;Database=Emp;User Id=sa;Password=Bloodbank@123;TrustServerCertificate=True;"
));
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend",
                    policy =>
                    {
                        policy
                            .WithOrigins("http://localhost:5173") // Vite
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("AllowFrontend");
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
