using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Geography
{
    public class CountryRepositorySession : EntityRepositorySession<EFCountry>
    {
        protected override DbSet<EFCountry> Table => _context.Countries;

        public CountryRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
