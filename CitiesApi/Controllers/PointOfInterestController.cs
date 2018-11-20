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
		[HttpGet("{cityId}/pointofinterest/{id}", Name = "GetPointOfInterest")]
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

		[HttpPost("{cityId}/pointofinterest")]
		public IActionResult CreatePointOfInterest(int cityId, [FromBody] PointOfInterestCreation pointOfInterest)
		{
			if (pointOfInterest == null)
			{
				return BadRequest();
			}
			var city = CityStore.Cities_.FirstOrDefault(c => c.Id == cityId);
			if (city == null)
			{
				return NotFound();
			}

			var maxPointOfInterestId = CityStore.Cities_.SelectMany(c => c.PointOfInterest).Max(p => p.Id);
			var finalPointOfInterest = new PointOfInterest()
			{
				Id = ++maxPointOfInterestId,
				Name = pointOfInterest.Name,
				Description = pointOfInterest.Description
			};
			city.PointOfInterest.Add(finalPointOfInterest);
			return CreatedAtRoute("GetPointOfInterest", new {cityId = cityId, Id = finalPointOfInterest.Id}, finalPointOfInterest);
		}


	}
}
