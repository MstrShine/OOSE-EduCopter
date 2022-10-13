using EduCopter.Domain;
using EduCopter.Persistency.Persistence.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.Persistence.Repository
{
    public interface IEntityRepositorySession<E> : IDisposable, IEntityProvider<E> where E : Entity
    {
    }
}
