using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitiesApi.Models;

namespace CitiesApi.Controllers
{
	[Route("api/cities")]
	public class CitiesController : Controller
	{
		[HttpGet()]
		public IActionResult GetCities()
		{
			return Ok(CitiesStore.Current.Cities_);
		}
		[HttpGet("{Id}")]
		public IActionResult GetCity(int id)
		{
			var cityToReturn = CitiesStore.Current.Cities_.FirstOrDefault(c => c.Id == id);
			if (cityToReturn == null)
			{
				return NotFound();
			}
			return Ok(cityToReturn);
		}
    }
}