using EduCopter.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace EduCopter.Persistency.Persistence.Extensions
{
    public static class PersistenceExtension
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddEntityManager<E>(this IServiceCollection services) where E : Entity
        {
            //services.AddTransient<AbstractManagerSession<E>>()
            //.AddTransient<IManagerSession<E>, AbstractManagerSession<E>>(s => s.GetService<AbstractManagerSession<E>>());

            //services.AddScoped<IEntityManager<E>, MachineChildManager<T>>();
            return services;
        }
    }
}
