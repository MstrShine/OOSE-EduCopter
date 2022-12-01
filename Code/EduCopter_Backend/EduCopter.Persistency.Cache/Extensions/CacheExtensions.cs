using EduCopter.Persistency.Cache.Missions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
