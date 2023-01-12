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
                CountryId = ef.CountryId,
            };
        }

        public static EFProvince Convert(Province e)
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                CountryId = e.CountryId,
            };
        }
    }
}
