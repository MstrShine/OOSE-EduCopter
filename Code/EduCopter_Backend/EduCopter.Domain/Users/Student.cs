namespace EduCopter.Domain.Users
{
    public class Student : UserInfo
    {
        public Guid SchoolId { get; set; }

        public Guid ClassId { get; set; }

        public Student() { }
    }
}
