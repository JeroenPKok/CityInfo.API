using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Amsterdam",
                    Description = "The one with all the canals.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Canals",
                            Description = "Too many to count!"
                        },

                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Red Light District",
                            Description = "What are you looking at?"
                        },

                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Bicycles",
                            Description = "They are everywhere!"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Toronto",
                    Description = "The one with the Blue Jays.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Rogers Center",
                            Description = "Home of the Blue Jays!"
                        },

                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "CN Tower",
                            Description = "I love the Sky-Walk!"
                        }
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "New York",
                    Description = "The one that is a Big Apple.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Central Park",
                            Description = "The place of the famous Simon & Garfunkel concert."
                        }
                    }
                }
            };
        }
    }
}
