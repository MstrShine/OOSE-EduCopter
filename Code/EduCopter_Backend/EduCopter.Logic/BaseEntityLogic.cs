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

        public virtual async Task<E> Get(Guid id)
        {
            E entity;
            using (var session = _repository.CreateSession())
            {
                var efEntity = await session.Get(id);
                entity = Convert(efEntity);
            }

            return entity;
        }

        public virtual async Task<List<E>> GetAll()
        {
            List<E> entityList;
            using (var session = _repository.CreateSession())
            {
                var efList = await session.GetAll();
                entityList = efList.Select(x => Convert(x)).ToList();
            }

            return entityList;
        }

        public virtual async Task<E> SaveOrUpdate(E entity)
        {
            E updatedEntity;
            using (var session = _repository.CreateSession())
            {
                var efEntity = await session.SaveOrUpdate(Convert(entity));
                updatedEntity = Convert(efEntity);
            }

            return updatedEntity;
        }

        public virtual async Task Delete(Guid id)
        {
            using (var session = _repository.CreateSession())
            {
                await session.Delete(id);
            }
        }

        protected abstract E Convert(EF entity);

        protected abstract EF Convert(E entity);
    }
}
