using EduCopter.Domain.Game;
using EduCopter.Domain.Geography;
using EduCopter.Logic.Convert.Game;
using EduCopter.Logic.Convert.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Geography
{
    public static class CityConverter
    {
        public static City Convert(EFCity ef) 
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
                Population = ef.Population,
                Province = ProvinceConverter.Convert(ef.Province),
                GameCities = ef.GameCities.Select(x => GameCityConverter.Convert(x)).ToList(),
                MissionCities = ef.MissionCities.Select(x => MissionCityConverter.Convert(x)).ToList()
            };
        }

        public static EFCity Convert(City e) 
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                Population = e.Population,
                ProvinceId = e.Province.Id,
                Province = ProvinceConverter.Convert(e.Province),
                GameCities = e.GameCities.Select(x => GameCityConverter.Convert(x)).ToList(),
                MissionCities = e.MissionCities.Select(x => MissionCityConverter.Convert(x)).ToList()
            };
        }
    }
}
