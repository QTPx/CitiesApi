using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApi.Models
{
	public class Cities
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<PointOfInterest> PointOfInterest { get; set; }
	}

}
