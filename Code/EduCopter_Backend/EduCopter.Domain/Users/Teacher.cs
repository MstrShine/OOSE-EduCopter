using EduCopter.Domain.School;

namespace EduCopter.Domain.Users
{
    public class Teacher : UserInfo
    {
        public Guid SchoolId { get; set; }

        public Guid ClassId { get; set; }
    }
}
