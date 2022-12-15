using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Repository.Interfaces;

namespace EduCopter.Persistency.DataBase.Repository
{
    public class EntityRepository<EF> : IEntityRepository<EF> where EF : EFEntity
    {
        private readonly IServiceProvider _service;

        public EntityRepository(IServiceProvider serviceProvider)
        {
            _service = serviceProvider;
        }

        public IEntityRepositorySession<EF> CreateSession()
        {
            return (IEntityRepositorySession<EF>)_service.GetService(typeof(IEntityRepositorySession<EF>));
        }
    }
}
