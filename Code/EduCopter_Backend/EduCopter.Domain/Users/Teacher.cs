namespace EduCopter.Domain.Users
{
    public class Teacher : UserInfo
    {
        public Guid ClassId { get; set; }

        public Guid SchoolId { get; set; }

        public Teacher() { }
    }
}
