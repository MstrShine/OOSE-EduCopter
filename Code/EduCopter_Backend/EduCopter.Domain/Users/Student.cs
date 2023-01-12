using EduCopter.Domain.Game;
using EduCopter.Domain.Mission;
using EduCopter.Domain.School;

namespace EduCopter.Domain.Users
{
    public class Student : UserInfo
    {
        public School.School School { get; set; }

        public Class Class { get; set; }

        public List<StudentMission> StudentMissions { get; set; }

        public List<Game.Game> Games { get; set; }
    }
}
