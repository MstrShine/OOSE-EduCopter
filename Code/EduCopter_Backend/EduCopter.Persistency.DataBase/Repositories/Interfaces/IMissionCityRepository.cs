using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;

namespace EduCopter.Persistency.DataBase.Repositories.Interfaces
{
    public interface IMissionCityRepository
    {
        IMissionCityRepositorySession CreateSession();
    }
}
