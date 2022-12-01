using EduCopter.Domain.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.Cache.Missions
{
    public interface IMissionCache
    {
        Task<Mission> Get(Guid id);

        Task AddOrChange(Mission mission);
    }
}
