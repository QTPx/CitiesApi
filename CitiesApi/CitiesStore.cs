using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApi.Models
{
	public class CitiesStore
	{
		public static CitiesStore Current { get; } = new CitiesStore();

		public List<Cities> Cities_ { get; set; }
		public CitiesStore()
		{
			Cities_ = new List<Cities>()
			{
				new Cities()
				{
					Id = 1,
					Name = "Odense",
					Description = "Største by på Fyn",
					PointOfInterest = new List<PointOfInterest>()
					{
						new PointOfInterest()
						{
							Id = 1,
							Name = "H.C. Andersens Hus",
							Description = "H.C. Andersens Hus i Odense er hovedmuseet for eventyrdigteren og forfatteren H.C. Andersen."
						},
						new PointOfInterest()
						{
							Id = 2,
							Name = "Den Fynske Landsby",
							Description = "Den Fynske Landsby er et frilandsmuseum i Odense, som indeholder gårde og huse, som de så ud på Fyn i 1800-tallet."
						}
					}
				},
				new Cities()
				{
					Id = 2,
					Name = "Århus",
					Description = "Største by i Jylland",
					PointOfInterest = new List<PointOfInterest>()
					{
						new PointOfInterest()
						{
							Id = 3,
							Name = "Den Gamle By",
							Description = "Den Gamle By, Danmarks Købstadmuseum, er et frilandsmuseum for bykultur på Vesterbro i Aarhus Midtby."
						},
						new PointOfInterest()
						{
							Id = 4,
							Name = "ARoS Aarhus Kunstmuseum",
							Description = "ARoS Aarhus Kunstmuseum er et kunstmuseum, der ligger i Aarhus centrum."
						}
					}
				},
				new Cities()
				{
					Id = 3,
					Name = "København",
					Description = "Støreste by i Danmark",
					PointOfInterest = new List<PointOfInterest>()
					{
						new PointOfInterest()
						{
							Id = 5,
							Name = "Tivoli",
							Description = "Københavns Tivoli er en forlystelsespark beliggende i centrum af København tæt ved Hovedbanegården og Strøget."
						},
						new PointOfInterest()
						{
							Id = 6,
							Name = "Nyhavn",
							Description = "Nyhavn er et havnekvarter i København, som er et af byens mest besøgte turistmål."
						}
					}
				}
			};
		}
	}
}
