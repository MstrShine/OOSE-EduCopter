using EduCopter.Persistency.DataBase.Repositories.Interfaces;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories
{
    public class MissionCityRepository : IMissionCityRepository
    {
        private readonly IServiceProvider _service;

        public MissionCityRepository(IServiceProvider service)
        {
            _service = service;
        }

        public IMissionCityRepositorySession CreateSession()
        {
            return (IMissionCityRepositorySession)_service.GetService(typeof(IMissionCityRepositorySession));
        }
    }
}
