using AMD201official2.Data.Models;
using AMD201official2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using System.Runtime.CompilerServices;
using AMD201official2.Interfaces;

namespace AMD201official2.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class UrlController : Controller
	{
		//private readonly IUrlRepository _urlRepository;
		//private readonly IMapper _mapper;

		//public UrlController(IUrlRepository urlRepository, IMapper mapper)
		//{
		//	_urlRepository = urlRepository;
		//	_mapper = mapper;
		//}

		//[HttpGet]
		//public async Task<ActionResult<IEnumerable<UrlDto>>> GetUrls()
		//{
		//	var urls = await _urlRepository.GetAllUrls();
		//	return _mapper.Map<List<UrlDto>>(urls);
		//}

		//[HttpGet("{id}")]
		//public async Task<ActionResult<UrlDto>> GetUrl(int id)
		//{
		//	var url = await _urlRepository.GetUrlById(id);

		//	if (url == null) { return NotFound(); }
		//	return _mapper.Map<UrlDto>(url);
		//}

		//[HttpPost]
		//public async Task<ActionResult<UrlDto>> PostUrl (UrlDto urlDto)
		//{
		//	var url = _mapper.Map<Url>(urlDto);
		//	var addedUrl = await _urlRepository.AddUrl(url);

		//	return CreatedAtAction(nameof(GetUrl), new { id = addedUrl.Id }, _mapper.Map<UrlDto>(addedUrl));
		//}

		//[HttpDelete("{id}")]
		//public async Task<IActionResult> DeleteUrl (int id)
		//{
		//	var url = await _urlRepository.GetUrlById(id);

		//	if (url == null) { return NotFound(); }

		//	var deleted = await _urlRepository.DeleteUrl(id);
		//	if (deleted)
		//	{
		//		return NoContent();
		//	}
		//	else
		//	{
		//		return StatusCode(500);
		//	}
		//}

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


		//public IActionResult Copy(int id)
		//{
		//	return View();
		//}


		//public IActionResult Remove(int id)
		//{
		//	return View();
		//}
	}
}
