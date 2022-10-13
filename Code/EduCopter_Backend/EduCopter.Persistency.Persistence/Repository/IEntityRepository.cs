using EduCopter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.Persistence.Repository
{
    public interface IEntityRepository<S, E> where S : IEntityRepositorySession<E> where E : Entity
    {
        S CreateSession();
    }
}
