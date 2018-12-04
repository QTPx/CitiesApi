using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitiesApi.Entities;

namespace CitiesApi.Controllers
{
    public class DummyController : Controller
    {
		private CityInfoContext _ctx;
        public DummyController (CityInfoContext ctx)
        {
			_ctx = ctx;
        }

		[HttpGet]
		[Route("api/testdatabase")]
		public IActionResult testdatabase()
		{
			return Ok();
		}
		
    }
}