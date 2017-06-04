using System;
using System.Collections.Generic;
using FGWCityInfo.API.Models;

namespace FGWCityInfo.API.Helper
{
    public class CitiesDataStore
    {
        //create a static property to return all of the cities as a collection
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init sample data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Washington DC",
                    Description = "USA Nations Capital",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "National Mall",
                            Description = "Spans between the Lincoln Memorial and the US Capitol"
                        },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "Lincoln Memorial",
                            Description = "Statue of President Lincoln Seated in front of the Ellipse"
                        },
                        new PointOfInterestDto() {
                            Id = 3,
                            Name = "Washington Monumnet",
                            Description = "Iconic obelisk on the National Mall in Washington, D.C"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Laurel",
                    Description = "The only City to be in four counties",
										PointOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto() {
							Id = 4,
							Name = "Main Street",
							Description = "Historic Street with Old Shops and the Main Post Office"
						},
						new PointOfInterestDto() {
							Id = 5,
							Name = "Laurel Towne Centre",
							Description = "Open air Shopping Centre"
						}
					}
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Bellevue",
                    Description = "Where Microsoft and K2 located"
                }
            };

        }
    }
}
