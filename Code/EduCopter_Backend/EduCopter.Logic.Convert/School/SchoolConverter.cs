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
    public static class SchoolConverter
    {
        public static Domain.School.School Convert(EFSchool ef) 
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
            };
        }

        public static EFSchool Convert(Domain.School.School e) 
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
            };
        }
    }
}
