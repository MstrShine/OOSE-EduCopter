using EduCopter.Persistency.DataBase.Repositories.Interfaces;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories
{
    public class GameCityRepository : IGameCityRepository
    {
        private readonly IServiceProvider _service;

        public GameCityRepository(IServiceProvider service)
        {
            _service = service;
        }

        public IGameCityRepositorySession CreateSession()
        {
            return (IGameCityRepositorySession)_service.GetService(typeof(IGameCityRepositorySession));
        }
    }
}
