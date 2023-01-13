using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Mission
{
    public class MissionLogic : BaseEntityLogic<Domain.Mission.Mission, EFMission>
    {
        public MissionLogic(IEntityRepository<EFMission> repository) : base(repository)
        {
        }

        protected override Domain.Mission.Mission Convert(EFMission entity)
        {
            throw new NotImplementedException();
        }

        protected override EFMission Convert(Domain.Mission.Mission entity)
        {
            throw new NotImplementedException();
        }
    }
}
