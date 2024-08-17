using Microsoft.AspNetCore.Mvc;
using AMD201official2.Models;
using AMD201official2.Repository;
using System;
using System.Collections.Generic;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AMD201official2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UrlApiController : ControllerBase
	{

		private readonly IUrlRepository _urlRepository;
		public UrlApiController(IUrlRepository urlRepository)
		{
			_urlRepository = urlRepository;
		}

		// GET: api/<ValuesController>
		[HttpGet]
		public IActionResult Get()
		{
			var urls = _urlRepository.GetUrls();
			return new OkObjectResult(urls);
		}

		// GET api/<ValuesController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var url = _urlRepository.GetUrlByID(id);
			return new OkObjectResult(url);
		}

		// POST api/<ValuesController>
		[HttpPost]
		public IActionResult Post([FromBody] Url url)
		{
			using (var scope = new TransactionScope())
			{
				_urlRepository.InsertUrl(url);
				scope.Complete();
				return CreatedAtAction(nameof(Get), new { id = url.Id }, url);
			}
		}

		// PUT api/<ValuesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Url url)
		{
		}

		// DELETE api/<ValuesController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_urlRepository.DeleteUrl(id);
			return new OkResult();
		}
	}
}
