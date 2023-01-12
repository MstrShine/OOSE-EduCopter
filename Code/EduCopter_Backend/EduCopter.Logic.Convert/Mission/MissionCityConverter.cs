using EduCopter.Domain.Mission;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Persistency.DataBase.Domain.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Mission
{
    public static class MissionCityConverter
    {
        public static MissionCity Convert(EFMissionCity ef)
        {
            return new()
            {
                MissionOrder = ef.MissionOrder,
                City = CityConverter.Convert(ef.City),
                Mission = MissionConverter.Convert(ef.Mission),
            };
        }

        public static EFMissionCity Convert(MissionCity e)
        {
            return new()
            {
                MissionOrder = e.MissionOrder,
                CityId = e.City.Id,
                City = CityConverter.Convert(e.City),
                MissionId = e.Mission.Id,
                Mission = MissionConverter.Convert(e.Mission)
            };
        }
    }
}
