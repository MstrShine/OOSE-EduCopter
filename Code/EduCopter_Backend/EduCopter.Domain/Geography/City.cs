using EduCopter.Domain.Game;
using EduCopter.Domain.Mission;

namespace EduCopter.Domain.Geography
{
    public class City : Entity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public Province Province { get; set; }

        public List<MissionCity> MissionCities { get; set; }

        public List<GameCity> GameCities { get; set; }
    }
}
