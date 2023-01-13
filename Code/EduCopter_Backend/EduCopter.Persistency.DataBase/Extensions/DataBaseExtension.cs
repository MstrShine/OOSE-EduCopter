using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.School;
using EduCopter.Persistency.DataBase.Domain.Users;
using EduCopter.Persistency.DataBase.Repositories;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;
using EduCopter.Persistency.DataBase.Repositories.Interfaces.Sessions;
using EduCopter.Persistency.DataBase.Repositories.Sessions;
using EduCopter.Persistency.DataBase.Repositories.Sessions.Game;
using EduCopter.Persistency.DataBase.Repositories.Sessions.Geography;
using EduCopter.Persistency.DataBase.Repositories.Sessions.Mission;
using EduCopter.Persistency.DataBase.Repositories.Sessions.School;
using EduCopter.Persistency.DataBase.Repositories.Sessions.Users;
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
            services.AddEntityRepository<EFGame, GameRepositorySession>();
            services.AddEntityRepository<EFCity, CityRepositorySession>();
            services.AddEntityRepository<EFCountry, CountryRepositorySession>();
            services.AddEntityRepository<EFMap, MapRepositorySession>();
            services.AddEntityRepository<EFProvince, ProvinceRepositorySession>();
            services.AddEntityRepository<EFMission, MissionRepositorySession>();
            services.AddEntityRepository<EFClass, ClassRepositorySession>();
            services.AddEntityRepository<EFSchool, SchoolRepositorySession>();
            services.AddEntityRepository<EFAdministrator, AdministratorRepositorySession>();
            services.AddEntityRepository<EFStudent, StudentRepositorySession>();
            services.AddEntityRepository<EFTeacher, TeacherRepositorySession>();

            services.AddTransient<IGameCityRepositorySession, GameCityRepositorySession>();
            services.AddScoped<IGameCityRepository, GameCityRepository>();
            services.AddTransient<IMissionCityRepositorySession, MissionCityRepositorySession>();
            services.AddScoped<IMissionCityRepository, MissionCityRepository>();
            services.AddTransient<IStudentMissionRepositorySession, StudentMissionRepositorySession>();
            services.AddScoped<IStudentMissionRepository, StudentMissionRepository>();

            return services;
        }

        private static IServiceCollection AddEntityRepository<EF, RS>(this IServiceCollection services) where EF : EFEntity, new() where RS : EntityRepositorySession<EF>
        {
            services.AddTransient<IEntityRepositorySession<EF>, RS>();
            services.AddScoped<IEntityRepository<EF>, EntityRepository<EF>>();

            return services;
        }
    }
}
