using EduCopter.Domain.Users;

namespace EduCopter.Domain.School
{
    public class Class : Entity
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; } = new();

        public Teacher Teacher { get; set; }

        public Guid SchoolId { get; set; }

        public Class() { }
    }
}
