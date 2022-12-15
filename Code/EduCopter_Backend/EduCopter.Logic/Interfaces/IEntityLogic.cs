using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Logic.Interfaces
{
    public interface IEntityLogic<E> where E : Entity
    {
        Task<List<E>> GetAll();

        Task<E> Get(Guid id);

        Task<E> SaveOrUpdate(E entity);

        Task Delete(Guid id);
    }
}
