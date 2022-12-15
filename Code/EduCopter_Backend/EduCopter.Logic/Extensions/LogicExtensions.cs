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
            return services;
        }
    }
}
