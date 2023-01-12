using EduCopter.Logic.Convert.Game;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Logic.Convert.Users;
using EduCopter.Persistency.DataBase.Domain.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Mission
{
    public static class MissionConverter
    {
        public static Domain.Mission.Mission Convert(EFMission ef) 
        {
            return new()
            {
                Id = ef.Id,
                Date = ef.Date,
                Map = MapConverter.Convert(ef.Map),
                Teacher = TeacherConverter.Convert(ef.Teacher),
                Games = ef.Games.Select(x => GameConverter.Convert(x)).ToList(),
                MissionCities = ef.MissionCities.Select(x => MissionCityConverter.Convert(x)).ToList(),
                StudentMissions = ef.StudentMissions.Select(x => StudentMissionConverter.Convert(x)).ToList()
            };
        }

        public static EFMission Convert(Domain.Mission.Mission e) 
        {
            return new()
            {
                Id = e.Id,
                Date = e.Date,
                MapId = e.Map.Id,
                Map = MapConverter.Convert(e.Map),
                TeacherId = e.Teacher.Id,
                Teacher = TeacherConverter.Convert(e.Teacher),
                Games = e.Games.Select(x => GameConverter.Convert(x)).ToList(),
                MissionCities = e.MissionCities.Select(x => MissionCityConverter.Convert(x)).ToList(),
                StudentMissions = e.StudentMissions.Select(x => StudentMissionConverter.Convert(x)).ToList()
            };
        }
    }
}
