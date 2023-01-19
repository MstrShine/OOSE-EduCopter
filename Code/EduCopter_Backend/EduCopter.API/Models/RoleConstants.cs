using EduCopter.Domain.Users;

namespace EduCopter.API.Models
{
    public static class RoleConstants
    {
        public const string StudentAndTeacher = nameof(Student) + "," + nameof(Teacher) + "," + nameof(Administrator);

        public const string Student = nameof(Student) + "," + nameof(Administrator);

        public const string Teacher = nameof(Teacher) + "," + nameof(Administrator);
    }
}
