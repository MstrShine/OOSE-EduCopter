using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Repository.Interfaces
{
    public interface IEntityRepositorySession<E> : IDisposable, IEntityProvider<E> where E : Entity
    {
    }
}
