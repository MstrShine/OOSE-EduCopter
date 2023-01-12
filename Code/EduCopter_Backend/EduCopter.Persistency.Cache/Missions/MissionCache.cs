using EduCopter.Domain.Mission;
using EduCopter.Persistency.Cache.Models;
using System.Collections.Concurrent;

namespace EduCopter.Persistency.Cache.Missions
{
    public class MissionCache : IMissionCache
    {
        private readonly ConcurrentDictionary<Guid, MissionCacheModel> _Cache = new();

        public Task AddOrChange(Mission mission)
        {
            if (mission == null) throw new ArgumentNullException(nameof(mission));

            if (_Cache.TryGetValue(mission.Id, out var cached))
            {
                cached.AddCities(mission.MissionCities);
            }
            else
            {
                var cacheModel = new MissionCacheModel(mission);
                if (!_Cache.TryAdd(cacheModel.Id, cacheModel))
                {
                    throw new Exception("Something went wrong adding mission to cache");
                }
            }

            return Task.CompletedTask;
        }

        public Task<Mission> Get(Guid id)
        {
            if (_Cache.TryGetValue(id, out var cached))
            {
                return Task.FromResult(cached.Mission);
            }

            throw new KeyNotFoundException();
        }
    }
}
