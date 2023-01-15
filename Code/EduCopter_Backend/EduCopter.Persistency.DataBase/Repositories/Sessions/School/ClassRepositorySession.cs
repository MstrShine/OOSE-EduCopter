using EduCopter.Persistency.DataBase.Domain.School;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.School
{
    public class ClassRepositorySession : EntityRepositorySession<EFClass>
    {
        protected override DbSet<EFClass> Table => _context.Classes;

        public ClassRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
