using EduCopter.Domain.Users;
using EduCopter.Logic.Convert.Game;
using EduCopter.Logic.Convert.Mission;
using EduCopter.Logic.Convert.School;
using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Users
{
    public static class StudentConverter
    {
        public static Student Convert(EFStudent ef) 
        {
            return new()
            {
                Id = ef.Id,
                FirstName = ef.FirstName,
                LastName = ef.LastName,
                Email = ef.Email,
                Username = ef.Username,
                Password = ef.Password,
                ClassId = ef.ClassId,
                SchoolId = ef.SchoolId,
            };
        }

        public static EFStudent Convert(Student e)
        {
            return new()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,
                Username = e.Username,
                Password = e.Password,
                ClassId = e.ClassId,
                SchoolId = e.SchoolId,
            };
        }
    }
}
