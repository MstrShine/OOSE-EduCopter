using EduCopter.Domain.School;

namespace EduCopter.Domain.Users
{
    public class Teacher : UserInfo
    {
        public School.School School { get; set; }

        public Class Class { get; set; }
    }
}
