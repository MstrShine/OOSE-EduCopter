using EduCopter.Persistency.DataBase.Domain.Game;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Game
{
    public class GameRepositorySession : EntityRepositorySession<EFGame>
    {
        protected override DbSet<EFGame> Table => _context.Games;

        public GameRepositorySession(EduCopterContext context) : base(context)
        {
        }

    }
}
