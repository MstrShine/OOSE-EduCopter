using EduCopter.Domain.Game;
using EduCopter.Domain.Mission;
using EduCopter.Domain.School;

namespace EduCopter.Domain.Users
{
    public class Student : UserInfo
    {
        public Guid SchoolId { get; set; }

        public Guid ClassId { get; set; }
    }
}
