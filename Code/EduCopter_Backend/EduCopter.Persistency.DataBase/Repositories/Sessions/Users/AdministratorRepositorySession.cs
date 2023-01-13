using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Users
{
    public class AdministratorRepositorySession : EntityRepositorySession<EFAdministrator>
    {
        protected override DbSet<EFAdministrator> Table => _context.Administrators;

        public AdministratorRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
