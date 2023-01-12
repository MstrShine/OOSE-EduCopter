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
                Classes = ef.Classes.Select(x => ClassConverter.Convert(x)).ToList(),
                Students = ef.Students.Select(x => StudentConverter.Convert(x)).ToList(),
                Teachers = ef.Teachers.Select(x => TeacherConverter.Convert(x)).ToList()
            };
        }

        public static EFSchool Convert(Domain.School.School e) 
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                Classes = e.Classes.Select(x => ClassConverter.Convert(x)).ToList(),
                Students = e.Students.Select(x => StudentConverter.Convert(x)).ToList(),
                Teachers = e.Teachers.Select(x => TeacherConverter.Convert(x)).ToList()
            };
        }
    }
}
