using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Geography;

namespace EduCopter.Persistency.DataBase.Providers
{
    public interface IGameCityProvider
    {
        Task<List<EFCity>> GetCitiesForGame(Guid gameId);

        Task<List<EFGame>> GetGamesForCity(Guid cityId);

        Task<double> GetScoreOfGame(Guid gameId);

        Task<EFGameCity> SaveGameCity(Guid gameId, Guid cityId, int score);
    }
}
