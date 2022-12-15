using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repository.Sessions.Users
{
    public class StudentRepositorySession : EntityRepositorySession<EFStudent>
    {
        protected override DbSet<EFStudent> Table => _context.Students;

        public StudentRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
