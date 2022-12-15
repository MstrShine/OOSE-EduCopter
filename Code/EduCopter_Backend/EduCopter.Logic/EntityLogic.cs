using EduCopter.Domain;
using EduCopter.Logic.Interfaces;
using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Logic
{
    public abstract class EntityLogic<E, EF> : IEntityLogic<E, EF> where E : Entity where EF : EFEntity
    {
        protected abstract E Convert(EF entity);

        protected abstract EF Convert(E entity);
    }
}
