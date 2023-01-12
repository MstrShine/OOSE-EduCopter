using EduCopter.Domain.Game;
using EduCopter.Logic.Convert.Mission;
using EduCopter.Logic.Convert.Users;
using EduCopter.Persistency.DataBase.Domain.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Game
{
    public static class GameConverter
    {
        public static Domain.Game.Game Convert(EFGame ef)
        {
            return new()
            {
                Id = ef.Id,
                Date = ef.Date,
                Mission = MissionConverter.Convert(ef.Mission),
                Student = StudentConverter.Convert(ef.Student),
                GameCities = ef.GameCities.Select(x => GameCityConverter.Convert(x)).ToList()
            };
        }

        public static EFGame Convert(Domain.Game.Game e)
        {
            return new()
            {
                Id = e.Id,
                Date = e.Date,
                MissionId = e.Mission.Id,
                Mission = MissionConverter.Convert(e.Mission),
                StudentId = e.Student.Id,
                Student = StudentConverter.Convert(e.Student),
                GameCities = e.GameCities.Select(x => GameCityConverter.Convert(x)).ToList()
            };
        }
    }
}
