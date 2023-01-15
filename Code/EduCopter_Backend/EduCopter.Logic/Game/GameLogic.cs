using EduCopter.Logic.Convert.Game;
using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Game
{
    public class GameLogic : BaseEntityLogic<Domain.Game.Game, EFGame>
    {
        public GameLogic(IEntityRepository<EFGame> repository) : base(repository)
        {
        }

        protected override Domain.Game.Game Convert(EFGame entity)
        {
            return GameConverter.Convert(entity);
        }

        protected override EFGame Convert(Domain.Game.Game entity)
        {
            return GameConverter.Convert(entity);
        }
    }
}
