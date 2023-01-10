using EduCopter.Domain.Users;

namespace EduCopter.Domain.School
{
    public class School : Entity
    {
        public string Name { get; set; }

        public List<Class> Classes { get; set; } = new();

        public List<Student> Students { get; set; } = new();

        public List<Teacher> Teachers { get; set; } = new();

        public School() { }
    }
}
