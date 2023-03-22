using Adventures.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Adventures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                throw new InvalidOperationException(
                    "Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<AdventureContext>(options =>
               options.UseSqlite(connectionString));

            builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<AdventureContext>()
               .AddDefaultTokenProviders();

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddControllers(options
               => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "Account",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}