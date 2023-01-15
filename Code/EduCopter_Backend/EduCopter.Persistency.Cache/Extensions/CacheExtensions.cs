using EduCopter.Persistency.Cache.Missions;
using Microsoft.Extensions.DependencyInjection;

namespace EduCopter.Persistency.Cache.Extensions
{
    public static class CacheExtensions
    {
        public static IServiceCollection AddCaching(this IServiceCollection services)
        {
            services.AddSingleton<IMissionCache, MissionCache>();

            return services;
        }
    }
}
