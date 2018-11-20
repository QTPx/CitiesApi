using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitiesApi.Models;


namespace CitiesApi.Controllers
{
	[Route("api/cities")]
	public class PointOfInterestController : Controller
	{
		CitiesStore CityStore = new CitiesStore();
		[HttpGet("{CityId}/pointofinterest")]
		public IActionResult GetPointsOfInterest(int cityId)
		{
			var city = CityStore.Cities_.FirstOrDefault(c => c.Id == cityId);
			if (city == null)
			{
				return NotFound();
			}
			return Ok(city.PointOfInterest);
		}
		[HttpGet("{cityId}/pointofinterest/{id}")]
		public IActionResult GetPointOfInterest(int cityId, int id)
		{
			var city = CityStore.Cities_.FirstOrDefault(c => c.Id == cityId);
			if (city == null)
			{
				return NotFound();
			}
			var pointOfInterest = city.PointOfInterest.FirstOrDefault(c => c.Id == id);
			if (pointOfInterest==null)
			{
				return NotFound();
			}
			return Ok(pointOfInterest);
		}
	}
}
