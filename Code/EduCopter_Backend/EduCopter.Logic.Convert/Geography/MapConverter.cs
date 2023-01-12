using EduCopter.Domain.Geography;
using EduCopter.Logic.Convert.Mission;
using EduCopter.Persistency.DataBase.Domain.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Geography
{
    public static class MapConverter
    {
        public static Map Convert(EFMap ef)
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
                Path = ef.Path,
                Missions = ef.Missions.Select(x => MissionConverter.Convert(x)).ToList()
            };
        }

        public static EFMap Convert(Map e)
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                Path = e.Path,
                Missions = e.Missions.Select(x => MissionConverter.Convert(x)).ToList()
            };
        }
    }
}
