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
                CityId = ef.CityId,
                GameId = ef.GameId,
                Score = ef.Score
            };
        }

        public static EFGameCity Convert(GameCity e)
        {
            return new()
            {
                CityId = e.CityId,
                GameId = e.GameId,
                Score = e.Score
            };
        }
    }
}
