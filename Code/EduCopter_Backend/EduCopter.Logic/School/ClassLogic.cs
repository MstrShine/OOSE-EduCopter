using EduCopter.Domain.School;
using EduCopter.Persistency.DataBase.Domain.School;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.School
{
    public class ClassLogic : BaseEntityLogic<Class, EFClass>
    {
        public ClassLogic(IEntityRepository<EFClass> repository) : base(repository)
        {
        }

        protected override Class Convert(EFClass entity)
        {
            throw new NotImplementedException();
        }

        protected override EFClass Convert(Class entity)
        {
            throw new NotImplementedException();
        }
    }
}
