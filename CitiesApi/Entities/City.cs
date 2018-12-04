﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CitiesApi.Models;

namespace CitiesApi.Entities
{
	public class City
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<PointOfInterest> PointOfInterest { get; set; } = new List<PointOfInterest>();
	}
}
