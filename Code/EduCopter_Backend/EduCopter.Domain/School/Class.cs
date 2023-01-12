using EduCopter.Domain.Users;

namespace EduCopter.Domain.School
{
    public class Class : Entity
    {
        public string Name { get; set; }

        public Guid SchoolId { get; set; }
    }
}
