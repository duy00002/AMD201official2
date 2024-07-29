using AMD201official2.Models;
using Microsoft.EntityFrameworkCore;
namespace AMD201official2.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Url> Urls { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUrls(builder);
        }

        private void SeedUrls(ModelBuilder builder)
		{
			builder.Entity<Url>().HasData(
				new Url
				{
					Id = 1,
					OriginalLink = "https://original.com",
					ShortLink = "shrtly",
				},
				new Url()
				{
					Id = 2,
					OriginalLink = "https://lessoriginal.com",
					ShortLink = "shrtly2",

				},
				new Url()
				{
					Id = 3,
					OriginalLink = "https://evenlessoriginal.com",
					ShortLink = "shrtly3",

				},
				new Url()
				{
					Id = 4,
					OriginalLink = "https://devoidoforiginality.com",
					ShortLink = "shrtly4",

				}
			);
		}
	}
}
