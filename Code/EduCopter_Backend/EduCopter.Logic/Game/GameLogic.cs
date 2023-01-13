using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Game
{
    public class GameLogic : BaseEntityLogic<Domain.Game.Game, EFGame>
    {
        public GameLogic(IEntityRepository<EFGame> repository) : base(repository)
        {
        }

        protected override Domain.Game.Game Convert(EFGame entity)
        {
            throw new NotImplementedException();
        }

        protected override EFGame Convert(Domain.Game.Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
