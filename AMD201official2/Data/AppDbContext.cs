using AMD201official2.Models;
using Microsoft.EntityFrameworkCore;
namespace AMD201official2.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Url> Urls { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{ 

		}
	}
}
