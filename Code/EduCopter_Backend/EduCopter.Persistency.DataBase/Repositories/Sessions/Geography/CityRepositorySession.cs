using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Geography
{
    public class CityRepositorySession : EntityRepositorySession<EFCity>
    {
        protected override DbSet<EFCity> Table => _context.Cities;

        public CityRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
