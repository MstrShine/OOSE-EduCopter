using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Domain.Users;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
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
            services.AddTransient<IEntityRepositorySession<EFStudent>, StudentRepositorySession>();
            services.AddEntityRepository<EFStudent>();

            return services;
        }

        private static IServiceCollection AddEntityRepository<EF>(this IServiceCollection services) where EF : EFEntity, new()
        {
            //services.AddScoped<IEntityRepository<E>, EntityRepository<E>>();

            return services;
        }
    }
}
