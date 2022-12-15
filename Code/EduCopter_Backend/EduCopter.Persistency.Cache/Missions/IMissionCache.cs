using EduCopter.Domain.Mission;

namespace EduCopter.Persistency.Cache.Missions
{
    public interface IMissionCache
    {
        Task<Mission> Get(Guid id);

        Task AddOrChange(Mission mission);
    }
}
