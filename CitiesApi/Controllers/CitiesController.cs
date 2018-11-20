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
		CitiesStore CityStore = new CitiesStore();
		[HttpGet()]
		public IActionResult GetCities()
		{
			return Ok(CityStore.Cities_);
		}
		[HttpGet("{Id}")]
		public IActionResult GetCity(int id)
		{
			var cityToReturn = CityStore.Cities_.FirstOrDefault(c => c.Id == id);
			if (cityToReturn == null)
			{
				return NotFound();
			}
			return Ok(cityToReturn);
		}
    }
}