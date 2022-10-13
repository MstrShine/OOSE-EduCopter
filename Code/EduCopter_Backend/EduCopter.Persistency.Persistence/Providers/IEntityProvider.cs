using EduCopter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.Persistence.Providers
{
    public interface IEntityProvider<E> where E : Entity
    {
        Task<List<E>> GetAll();

        Task<E> Get(Guid id);

        Task<E> SaveOrUpdate(E entity);

        Task Delete(Guid id);
    }
}
