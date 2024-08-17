using System.Collections.Generic;
using AMD201official2.Models;
using Microsoft.EntityFrameworkCore;


namespace AMD201official2.Repository
{
	public interface IUrlRepository
	{
		IEnumerable<Url> GetUrls();
		Url GetUrlByID(int id);
		void InsertUrl (Url url);
		void DeleteUrl (int id);
		void Save();
	}
}
