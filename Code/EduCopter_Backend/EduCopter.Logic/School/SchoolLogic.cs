using EduCopter.Logic.Convert.School;
using EduCopter.Persistency.DataBase.Domain.School;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.School
{
    public class SchoolLogic : BaseEntityLogic<Domain.School.School, EFSchool>
    {
        public SchoolLogic(IEntityRepository<EFSchool> repository) : base(repository)
        {
        }

        protected override Domain.School.School Convert(EFSchool entity)
        {
            return SchoolConverter.Convert(entity);
        }

        protected override EFSchool Convert(Domain.School.School entity)
        {
            return SchoolConverter.Convert(entity);
        }
    }
}
