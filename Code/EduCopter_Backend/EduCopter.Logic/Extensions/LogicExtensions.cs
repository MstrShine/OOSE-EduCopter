using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using EduCopter.Logic.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Extensions
{
    public static class LogicExtensions
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            services.AddScoped<IEntityLogic<Student>, StudentLogic>();

            return services;
        }
    }
}
