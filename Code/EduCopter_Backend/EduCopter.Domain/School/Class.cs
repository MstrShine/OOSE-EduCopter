using EduCopter.Domain.Users;

namespace EduCopter.Domain.School
{
    public class Class : Entity
    {
        public string Name { get; set; }

        public School School { get; set; }

        public List<Student> Students { get; set; }
    }
}
