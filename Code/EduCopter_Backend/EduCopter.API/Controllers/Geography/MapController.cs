using CsvHelper;
using CsvHelper.Configuration;
using EduCopter.API.Models;
using EduCopter.Domain.Geography;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Geography
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class MapController : AbstractEntityController<Map>
    {
        private readonly IEntityLogic<Country> _countryLogic;
        private readonly IEntityLogic<Province> _provinceLogic;
        private readonly IEntityLogic<City> _citiesLogic;

        public MapController(IEntityLogic<Map> logic, IEntityLogic<Country> countryLogic, IEntityLogic<Province> provinceLogic, IEntityLogic<City> cityLogic) : base(logic)
        {
            _countryLogic = countryLogic;
            _provinceLogic = provinceLogic;
            _citiesLogic = cityLogic;
        }

        [HttpPost("csv/{mapName}/{countryName}")]
        public async Task<IActionResult> AddMapWithCsv(string mapName, string countryName, IFormFile mapCsv)
        {
            var cities = new List<CitiesCsv>();
            try
            {
                var stream = mapCsv.OpenReadStream();
                using (var reader = new StreamReader(stream))
                {
                    using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ",", MissingFieldFound = null }))
                    {
                        cities = csv.GetRecords<CitiesCsv>().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            var map = new Map()
            {
                Name = mapName,
                Path = ""
            };
            map = await _logic.SaveOrUpdate(map);

            var country = new Country()
            {
                Name = countryName,
                MapId = map.Id
            };
            country = await _countryLogic.SaveOrUpdate(country);

            var provinces = new List<Province>();
            foreach (var c in cities)
            {
                var province = provinces.FirstOrDefault(x => x.Name == c.Province);
                if (province == null)
                {
                    province = new Province()
                    {
                        Name = c.Province,
                        CountryId = country.Id,
                        MapId = map.Id
                    };
                    province = await _provinceLogic.SaveOrUpdate(province);
                    provinces.Add(province);
                }

                var city = new City()
                {
                    Name = c.City,
                    Population = c.Population,
                    ProvinceId = province.Id,
                    MapId = map.Id,
                };
                city = await _citiesLogic.SaveOrUpdate(city);
            }

            return Ok();
        }
    }
}
