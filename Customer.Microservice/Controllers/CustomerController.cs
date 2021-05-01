using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer.Microservice.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		// GET: api/<CustomerController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "Jane Merry", "Peter Parker" };
		}

		// GET api/<CustomerController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<CustomerController>
		[HttpPost]
		public void Post([FromBody] string value)
		{

		}
	}
}
