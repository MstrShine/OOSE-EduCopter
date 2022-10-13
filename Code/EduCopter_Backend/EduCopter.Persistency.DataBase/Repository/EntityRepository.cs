using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Repository
{
    public class EntityRepository<E> : IEntityRepository<E>  where E : Entity
    {
        private readonly IServiceProvider _service;

        public EntityRepository(IServiceProvider serviceProvider)
        {
            _service = serviceProvider;
        }

        public IEntityRepositorySession<E> CreateSession()
        {
            return (IEntityRepositorySession<E>)_service.GetService(typeof(IEntityRepositorySession<E>));
        }
    }
}
