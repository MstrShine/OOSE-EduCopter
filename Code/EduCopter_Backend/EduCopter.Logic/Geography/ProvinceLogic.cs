using EduCopter.Domain.Geography;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Geography
{
    public class ProvinceLogic : BaseEntityLogic<Province, EFProvince>
    {
        public ProvinceLogic(IEntityRepository<EFProvince> repository) : base(repository)
        {
        }

        protected override Province Convert(EFProvince entity)
        {
            return ProvinceConverter.Convert(entity);
        }

        protected override EFProvince Convert(Province entity)
        {
            return ProvinceConverter.Convert(entity);
        }
    }
}
