using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApi.Entities
{
	public class CityInfoContext : DbContext
	{
		public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
		public DbSet<City> Cities { get; set; }
		public DbSet<PointOfInterest> PointOfInterests { get; set; }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer("ConnectionString");
		//	base.OnConfiguring(optionsBuilder);
		//}
	}
}
