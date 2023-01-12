using EduCopter.Domain.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Geography
{
    public static class ProvinceConverter
    {
        public static Province Convert(EFProvince ef)
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
                Country = CountryConverter.Convert(ef.Country),
                Cities = ef.Cities.Select(x => CityConverter.Convert(x)).ToList()
            };
        }

        public static EFProvince Convert(Province e)
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                CountryId = e.Country.Id,
                Country = CountryConverter.Convert(e.Country),
                Cities = e.Cities.Select(x => CityConverter.Convert(x)).ToList(),
            };
        }
    }
}
