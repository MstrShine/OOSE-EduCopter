using EduCopter.Domain;
using EduCopter.Logic.Interfaces;
using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Repository.Interfaces;

namespace EduCopter.Logic
{
    public abstract class BaseEntityLogic<E, EF> : IEntityLogic<E, EF> where E : Entity where EF : EFEntity
    {
        protected readonly IEntityRepository<EF> _repository;

        public BaseEntityLogic(IEntityRepository<EF> repository)
        {
            _repository = repository;
        }

        public abstract void Delete(Guid id);

        public abstract E Get(Guid id);

        public abstract List<E> GetAll();

        public abstract E SaveOrUpdate(E entity);

        protected abstract E Convert(EF entity);

        protected abstract EF Convert(E entity);
    }
}
