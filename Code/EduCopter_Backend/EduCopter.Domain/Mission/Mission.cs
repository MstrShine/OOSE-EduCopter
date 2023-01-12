using EduCopter.Domain.Game;
using EduCopter.Domain.Geography;
using EduCopter.Domain.Users;

namespace EduCopter.Domain.Mission
{
    public class Mission : Entity
    {
        public DateTime Date { get; set; }

        public Map Map { get; set; }

        public Teacher Teacher { get; set; }

        public List<MissionCity> MissionCities { get; set; }

        public List<StudentMission> StudentMissions { get; set; }

        public List<Game.Game> Games { get; set; }
    }
}
