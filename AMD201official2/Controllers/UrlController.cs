using AMD201official2.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMD201official2.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
			//Data is from DB
			var url1 = new Url()
			{
				Id = 1,
				OriginalLink = "https://original.com",
				ShortLink = "shrtly",

			};

			var url2 = new Url()
			{
				Id = 2,
				OriginalLink = "https://lessoriginal.com",
				ShortLink = "shrtly2",

			};

			var url3 = new Url()
			{
				Id = 3,
				OriginalLink = "https://evenlessoriginal.com",
				ShortLink = "shrtly3",

			};

			var url4 = new Url()
			{
				Id = 4,
				OriginalLink = "https://devoidoforiginality.com",
				ShortLink = "shrtly4",

			};

			var allData = new List<Url>();
            allData.Add(url1);
			allData.Add(url2);
			allData.Add(url3);
			allData.Add(url4);

			ViewData["AllUrls"] = allData;

			return View();
        }

		public IActionResult Copy(int id)
		{
			return View();
		}

		public IActionResult Remove(int id)
		{
			return View();
		}
    }
}
