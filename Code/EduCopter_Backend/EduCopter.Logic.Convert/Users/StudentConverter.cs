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
                Class = ClassConverter.Convert(ef.Class),
                School = SchoolConverter.Convert(ef.School),
                Games = ef.Games.Select(x => GameConverter.Convert(x)).ToList(),
                StudentMissions = ef.StudentMissions.Select(x => StudentMissionConverter.Convert(x)).ToList()
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
                ClassId = e.Class.Id,
                Class = ClassConverter.Convert(e.Class),
                SchoolId = e.School.Id,
                School = SchoolConverter.Convert(e.School),
                Games = e.Games.Select(x => GameConverter.Convert(x)).ToList(),
                StudentMissions = e.StudentMissions.Select(x => StudentMissionConverter.Convert(x)).ToList()
            };
        }
    }
}
