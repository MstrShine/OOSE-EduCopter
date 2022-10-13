using EduCopter.Domain;
using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Repository;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using EduCopter.Persistency.DataBase.Repository.Sessions;
using EduCopter.Persistency.DataBase.Repository.Sessions.Users;
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
            services.AddTransient<IEntityRepositorySession<Student>, StudentRepositorySession>();
            services.AddEntityRepository<Student>();

            return services;
        }

        private static IServiceCollection AddEntityRepository<E>(this IServiceCollection services) where E : Entity, new()
        {
            services.AddScoped<IEntityRepository<E>, EntityRepository<E>>();

            return services;
        }
    }
}
