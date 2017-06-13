using System;
using System.Collections.Generic;
using System.Linq;
using FGWCityInfo.API.Entities;

namespace FGWCityInfo.API.Helper
{
    public static class CityInfoContextExtensions
    {
	    public static void EnsureSeedDataForContext (this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

			// init sample data
			var cities = new List<City>()
			{
				new City()
				{
					Name = "Washington DC",
					Description = "USA Nations Capital",
					PointOfInterest = new List<PointOfInterest>()
					{
						new PointOfInterest() {
							Name = "National Mall",
							Description = "Spans between the Lincoln Memorial and the US Capitol"
						},
						new PointOfInterest() {
							Name = "Lincoln Memorial",
							Description = "Statue of President Lincoln Seated in front of the Ellipse"
						},
						new PointOfInterest() {
							Name = "Washington Monumnet",
							Description = "Iconic obelisk on the National Mall in Washington, D.C"
						}
					}
				},
				new City()
				{
					Name = "Laurel",
					Description = "The only City to be in four counties",
					PointOfInterest = new List<PointOfInterest>()
					{
						new PointOfInterest() {
							Name = "Main Street",
							Description = "Historic Street with Old Shops and the Main Post Office"
						},
						new PointOfInterest() {
							Name = "Laurel Towne Centre",
							Description = "Open air Shopping Centre"
						}
					}
				},
				new City()
				{
					Name = "Bellevue",
					Description = "Where Microsoft and K2 located"
				}
			};

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
