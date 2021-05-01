using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Microservice.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		// GET: api/<ProductController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "Product One", "Product Two" };
		}

		// GET api/<ProductController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "Procuct Id :" + id;
		}

		// POST api/<ProductController>
		[HttpPost]
		public string Post([FromBody] string value)
		{
			return value;
		}
	}
}
