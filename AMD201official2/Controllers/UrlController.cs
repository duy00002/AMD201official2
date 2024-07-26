using AMD201official2.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMD201official2.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            //Data is from DB

            var urlDb = new Url()
            {
                Id = 1,
                OriginalLink = "Https://original.com",
                ShortLink = "shrtly",

            };

            var allData = new List<Url>();
            allData.Add(urlDb);

            return View(allData);
        }
    }
}
