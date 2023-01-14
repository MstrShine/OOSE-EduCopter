using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Users
{
    public class TeacherRepositorySession : EntityRepositorySession<EFTeacher>
    {
        protected override DbSet<EFTeacher> Table => _context.Teachers;

        public TeacherRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
