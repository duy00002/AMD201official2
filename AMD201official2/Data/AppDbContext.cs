using AMD201official2.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace AMD201official2.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

		public DbSet<Url> Urls { get; set; }
	}
}
