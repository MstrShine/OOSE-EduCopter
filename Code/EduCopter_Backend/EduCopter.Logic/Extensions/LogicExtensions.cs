﻿using EduCopter.Domain.Geography;
using EduCopter.Domain.School;
using EduCopter.Domain.Users;
using EduCopter.Logic.Game;
using EduCopter.Logic.Geography;
using EduCopter.Logic.Interfaces;
using EduCopter.Logic.Mission;
using EduCopter.Logic.School;
using EduCopter.Logic.Users;
using Microsoft.Extensions.DependencyInjection;

namespace EduCopter.Logic.Extensions
{
    public static class LogicExtensions
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            services.AddTransient<IPasswordHandler, PasswordHandler>();

            services.AddScoped<IEntityLogic<Domain.Game.Game>, GameLogic>();
            services.AddScoped<IEntityLogic<City>, CityLogic>();
            services.AddScoped<IEntityLogic<Country>, CountryLogic>();
            services.AddScoped<IEntityLogic<Map>, MapLogic>();
            services.AddScoped<IEntityLogic<Province>, ProvinceLogic>();
            services.AddScoped<IEntityLogic<Domain.Mission.Mission>, MissionLogic>();
            services.AddScoped<IEntityLogic<Class>, ClassLogic>();
            services.AddScoped<IEntityLogic<Domain.School.School>, SchoolLogic>();
            services.AddScoped<IEntityLogic<Administrator>, AdministratorLogic>();
            services.AddScoped<IEntityLogic<Student>, StudentLogic>();
            services.AddScoped<IEntityLogic<Teacher>, TeacherLogic>();

            return services;
        }
    }
}