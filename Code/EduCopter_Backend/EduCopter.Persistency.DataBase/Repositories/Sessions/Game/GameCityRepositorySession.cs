using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.Persistency.DataBase.Repositories.Sessions.Game
{
    public class GameCityRepositorySession : IGameCityRepositorySession
    {
        private readonly EduCopterContext _context;

        private DbSet<EFGameCity> Table => _context.GameCities;

        private bool disposedValue;

        public GameCityRepositorySession(EduCopterContext context)
        {
            _context = context;
        }

        public async Task<List<EFCity>> GetCitiesForGame(Guid gameId)
        {
            if (gameId == Guid.Empty)
                throw new ArgumentNullException(nameof(gameId));

            var cityIds = await Table.Where(x => x.GameId == gameId).Select(x => x.CityId).ToListAsync();
            var cities = await _context.Cities.Where(x => cityIds.Contains(x.Id)).ToListAsync();

            return cities;
        }

        public async Task<List<EFGame>> GetGamesForCity(Guid cityId)
        {
            if (cityId == Guid.Empty)
                throw new ArgumentNullException(nameof(cityId));

            var gameIds = await Table.Where(x => x.CityId == cityId).Select(x => x.GameId).ToListAsync();
            var games = await _context.Games.Where(x => gameIds.Contains(x.Id)).ToListAsync();

            return games;
        }

        public async Task<double> GetScoreOfGame(Guid gameId)
        {
            var total = 0d;
            var scores = await Table.Where(x => x.GameId == gameId).Select(x => x.Score).ToListAsync();
            scores.ForEach(x => total += x);

            return total;
        }

        public async Task<EFGameCity> SaveGameCity(Guid gameId, Guid cityId, int score)
        {
            if (gameId == Guid.Empty)
                throw new ArgumentNullException(nameof(gameId));

            if (cityId == Guid.Empty)
                throw new ArgumentNullException(nameof(cityId));

            if (score < 0)
                throw new ArgumentOutOfRangeException(nameof(score));

            var gameCity = new EFGameCity(score, gameId, cityId);
            await Table.AddAsync(gameCity);
            await _context.SaveChangesAsync();

            return gameCity;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~GameCityRepositorySession()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
