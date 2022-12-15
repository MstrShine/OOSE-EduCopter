using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Logic.Interfaces
{
    public interface IEntityLogic<E, EF> where E : Entity where EF : EFEntity
    {
        List<E> GetAll();

        E Get(Guid id);

        E SaveOrUpdate(E entity);

        void Delete(Guid id);
    }
}
