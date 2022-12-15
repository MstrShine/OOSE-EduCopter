using EduCopter.Domain;
using EduCopter.Logic.Interfaces;
using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Repository.Interfaces;

namespace EduCopter.Logic
{
    public abstract class BaseEntityLogic<E, EF> : IEntityLogic<E> where E : Entity where EF : EFEntity
    {
        protected readonly IEntityRepository<EF> _repository;

        public BaseEntityLogic(IEntityRepository<EF> repository)
        {
            _repository = repository;
        }

        public abstract Task Delete(Guid id);

        public abstract Task<E> Get(Guid id);

        public abstract Task<List<E>> GetAll();

        public abstract Task<E> SaveOrUpdate(E entity);

        protected abstract E Convert(EF entity);

        protected abstract EF Convert(E entity);
    }
}
