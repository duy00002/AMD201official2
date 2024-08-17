using AMD201official2.Data;
using AMD201official2.Models;
using System;
using System.Collections.Generic;

namespace AMD201official2.Repository
{
	public class UrlRepository: IUrlRepository
	{
		private readonly AppDbContext _url_context;

		public UrlRepository(AppDbContext url_context)
		{
			_url_context = url_context;
		}
		public IEnumerable<Url> GetUrls()
		{
			return _url_context.Urls.ToList();
		}
		public Url GetUrlByID(int id)
		{
			return _url_context.Urls.Find(id);
		}
		public void InsertUrl(Url url)
		{
			_url_context.Add(url);
			Save();
		}
		public void DeleteUrl(int id)
		{
			var url = _url_context.Urls.Find(id);
			_url_context.Urls.Remove(url);
			Save();
		}
		public void Save()
		{
			_url_context.SaveChanges();
		}
	}
}
