using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Geography
{
    public class MapRepositorySession : EntityRepositorySession<EFMap>
    {
        protected override DbSet<EFMap> Table => _context.Maps;

        public MapRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
