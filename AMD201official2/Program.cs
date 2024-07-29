using AMD201official2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using AspNetCoreRateLimit;
using System.Reflection;
using AMD201official2.Interfaces;
using AMD201official2.Repositories;
using Microsoft.Extensions.Configuration;
using AMD201official2.Models;
namespace AMD201official2
{
    public class Program
    {

        public static void Main(string[] args)
        {
			var builder = WebApplication.CreateBuilder(args);

			//Add database context and use SQL Server LocalDB
			builder.Services.AddDbContext<AppDbContext>(
				options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
			);

			builder.Services.AddRazorPages();
			builder.Services.AddControllers();

			//         //Add Repositories and Dependency Injection
			//         builder.Services.AddScoped<IUrlRepository, UrlRepository>();

			//         //Add AutoMapper
			//         builder.Services.AddAutoMapper(typeof(Program));

			//         // Add Swagger docs
			//         builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API Name", Version = "v1", Description = "Your API Description", }); });
			//         builder.Services.AddControllers();

			//// Configure rate limiting options
			//builder.Services.Configure<IpRateLimitOptions>(builder.Configuration.GetSection("IpRateLimiting"));
			//builder.Services.Configure<IpRateLimitPolicies>(builder.Configuration.GetSection("IpRateLimitPolicies"));
			//builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
			//// Add rate limiting middleware
			//builder.Services.AddMemoryCache(); // Add the IMemoryCache service here
			//builder.Services.AddInMemoryRateLimiting();
			//builder.Services.AddHttpContextAccessor();
			//builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
			//builder.Services.AddControllers();


			//Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
   //         app.UseIpRateLimiting();

   //         app.UseSwagger();
			//app.UseSwaggerUI(c => {c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name V1"); });

			//app.UseHttpsRedirection();
   //         app.UseStaticFiles();

   //         app.UseRouting();

   //         app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
