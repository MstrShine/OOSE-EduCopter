using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Geography
{
    public class ProvinceRepositorySession : EntityRepositorySession<EFProvince>
    {
        protected override DbSet<EFProvince> Table => _context.Provinces;

        public ProvinceRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
