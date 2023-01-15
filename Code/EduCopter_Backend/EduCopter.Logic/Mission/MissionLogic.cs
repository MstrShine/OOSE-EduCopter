using EduCopter.Logic.Convert.Mission;
using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Mission
{
    public class MissionLogic : BaseEntityLogic<Domain.Mission.Mission, EFMission>
    {
        public MissionLogic(IEntityRepository<EFMission> repository) : base(repository)
        {
        }

        protected override Domain.Mission.Mission Convert(EFMission entity)
        {
            return MissionConverter.Convert(entity);
        }

        protected override EFMission Convert(Domain.Mission.Mission entity)
        {
            return MissionConverter.Convert(entity);
        }
    }
}
