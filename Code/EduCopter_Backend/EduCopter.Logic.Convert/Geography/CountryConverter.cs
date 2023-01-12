using EduCopter.Domain.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Geography
{
    public static class CountryConverter
    {
        public static Country Convert(EFCountry ef) 
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
            };
        }

        public static EFCountry Convert(Country e) 
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
            };
        }
    }
}
