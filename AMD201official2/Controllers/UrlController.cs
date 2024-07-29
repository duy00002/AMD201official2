﻿using AMD201official2.Models;
using AMD201official2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;


namespace AMD201official2.Controllers
{

	public class UrlController : Controller
	{
		private readonly AppDbContext _context;
		public UrlController(AppDbContext context)
		{
			_context = context;
		}

        public async Task<IActionResult> Index()
        {
            return View(await _context.Urls.ToListAsync());
        }

        // Get: Url/Details
        public async Task<IActionResult> Details (int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var url = await _context.Urls.FirstOrDefaultAsync(url => url.Id == id);
			if (url == null) { return NotFound(); }
			return View(url);
		}

		public IActionResult Create()
		{
			ViewData["ShortenedUrl"] = RandomString(8);
			return View();
		}

		//Post: Url/Create
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OriginalLink,ShortLink")] Url url)
		{
			if (ModelState.IsValid)
			{
				_context.Add(url);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

        // Get: Url/Remove/5
        public async Task<IActionResult> Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var url = await _context.Urls
                .FirstOrDefaultAsync(url => url.Id == id);
            if (url == null)
            {
                return NotFound();
            }

            return View(url);
        }

		// Post: Url/Remove/5
		[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveConfirmed(int id)
        {
            var url = await _context.Urls.FindAsync(id);
            if (url != null)
            {
                _context.Urls.Remove(url);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrlExists(int id)
        {
            return _context.Urls.Any(url => url.Id == id);
        }


		private static Random random = new Random();
		public static string RandomString(int length)
		{
			const string chars = "qwertyuiopasdfghjklzxcvbnmABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());
		}

	}
}
