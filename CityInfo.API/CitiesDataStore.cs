using CityInfo.API.Models;
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
            Cities = new List<CityDto>
            {
                new CityDto { Id = 1, Name = "Madrid", Description = "Test description 1"},
                new CityDto { Id = 2, Name = "Barcelona", Description = "Test description 2"},
                new CityDto { Id = 3, Name = "A Coruna", Description = "Test description 3"},
            };
        }
    }
}
