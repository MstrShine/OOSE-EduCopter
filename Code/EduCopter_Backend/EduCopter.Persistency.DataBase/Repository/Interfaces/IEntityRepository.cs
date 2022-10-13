using EduCopter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Repository.Interfaces
{
    public interface IEntityRepository<E> : IBaseRepository<IEntityRepositorySession<E>, E> where E : Entity, new()
    {
    }
}
