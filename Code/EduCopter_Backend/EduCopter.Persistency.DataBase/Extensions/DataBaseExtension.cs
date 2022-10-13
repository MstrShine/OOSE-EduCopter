using EduCopter.Domain;
using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Repository;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using EduCopter.Persistency.DataBase.Repository.Sessions;
using Microsoft.Extensions.DependencyInjection;

namespace EduCopter.Persistency.DataBase.Extensions
{
    public static class DataBaseExtension
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services)
        {
            services.AddDbContext<EduCopterContext>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddEntityRepository<Student>();

            return services;
        }

        private static IServiceCollection AddEntityRepository<E>(this IServiceCollection services) where E : Entity, new()
        {
            services.AddTransient<EntityRepositorySession<E>>()
                .AddTransient<IEntityRepositorySession<E>, EntityRepositorySession<E>>(s => s.GetRequiredService<EntityRepositorySession<E>>());

            services.AddScoped<IEntityRepository<E>, EntityRepository<E>>();

            return services;
        }
    }
}
