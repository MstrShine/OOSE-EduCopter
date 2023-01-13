using EduCopter.Persistency.DataBase.Domain.School;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.School
{
    public class SchoolRepositorySession : EntityRepositorySession<EFSchool>
    {
        protected override DbSet<EFSchool> Table => _context.Schools;

        public SchoolRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
