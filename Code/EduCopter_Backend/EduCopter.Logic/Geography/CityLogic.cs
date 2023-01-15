using EduCopter.Domain.Geography;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Geography
{
    public class CityLogic : BaseEntityLogic<City, EFCity>
    {
        public CityLogic(IEntityRepository<EFCity> repository) : base(repository)
        {
        }

        protected override City Convert(EFCity entity)
        {
            return CityConverter.Convert(entity);
        }

        protected override EFCity Convert(City entity)
        {
            return CityConverter.Convert(entity);
        }
    }
}
