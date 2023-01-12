using EduCopter.Domain.Users;
using EduCopter.Logic.Convert.School;
using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Users
{
    public static class TeacherConverter
    {
        public static Teacher Convert(EFTeacher ef)
        {
            return new()
            {
                Id = ef.Id,
                FirstName = ef.FirstName,
                LastName = ef.LastName,
                Username = ef.Username,
                Password = ef.Password,
                Email = ef.Email,
                ClassId = ef.ClassId,
                SchoolId = ef.SchoolId,
            };
        }

        public static EFTeacher Convert(Teacher e)
        {
            return new()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Username = e.Username,
                Password = e.Password,
                Email = e.Email,
                ClassId = e.ClassId,
                SchoolId = e.SchoolId,
            };
        }
    }
}
