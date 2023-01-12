using EduCopter.Domain.School;
using EduCopter.Logic.Convert.Users;
using EduCopter.Persistency.DataBase.Domain.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.School
{
    public static class ClassConverter
    {
        public static Class Convert(EFClass ef)
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
                SchoolId = ef.SchoolId,
            };
        }

        public static EFClass Convert(Class e)
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                SchoolId = e.SchoolId,
            };
        }
    }
}
