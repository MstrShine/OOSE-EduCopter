using EduCopter.Persistency.DataBase.Domain.Mission;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Mission
{
    public class MissionRepositorySession : EntityRepositorySession<EFMission>
    {
        protected override DbSet<EFMission> Table => _context.Missions;

        public MissionRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
