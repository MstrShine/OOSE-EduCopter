using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Geography
{
    public class MapLogic : BaseEntityLogic<Map, EFMap>
    {
        public MapLogic(IEntityRepository<EFMap> repository) : base(repository)
        {
        }

        protected override Map Convert(EFMap entity)
        {
            throw new NotImplementedException();
        }

        protected override EFMap Convert(Map entity)
        {
            throw new NotImplementedException();
        }
    }
}
