using EduCopter.Domain.Game;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Persistency.DataBase.Domain.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Game
{
    public static class GameCityConverter
    {
        public static GameCity Convert(EFGameCity ef)
        {
            return new()
            {
                City = CityConverter.Convert(ef.City),
                Game = GameConverter.Convert(ef.Game),
                Score = ef.Score
            };
        }

        public static EFGameCity Convert(GameCity e)
        {
            return new()
            {
                CityId = e.City.Id,
                City = CityConverter.Convert(e.City),
                GameId = e.Game.Id,
                Game = GameConverter.Convert(e.Game),
                Score = e.Score
            };
        }
    }
}
