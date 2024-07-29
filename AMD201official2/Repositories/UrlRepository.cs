using AMD201official2.Models;
using AMD201official2.Data;
using AMD201official2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AMD201official2.Repositories
{
	public class UrlRepository: IUrlRepository
	{
		public readonly AppDbContext _context;
		public UrlRepository(AppDbContext context) { _context = context; }
		public async Task<IEnumerable<Url>> GetAllUrls()
		{
			return await _context.Urls.ToListAsync(); 
		}
		public async Task<Url> GetUrlById(int id)
		{
			return await _context.Urls.FindAsync(id);
		}
		public async Task<Url> AddUrl(Url url)
		{
			_context.Urls.Add(url);
			await _context.SaveChangesAsync();
			return url;
		}
		public async Task<bool> DeleteUrl(int id)
		{
			var url = await _context.Urls.FindAsync(id);
			if (url == null) return false;

			_context.Urls.Remove(url);
			await _context.SaveChangesAsync();
			return true;
		}
	}
}

