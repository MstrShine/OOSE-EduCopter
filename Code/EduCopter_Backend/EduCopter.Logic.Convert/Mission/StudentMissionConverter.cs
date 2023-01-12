using EduCopter.Domain.Mission;
using EduCopter.Logic.Convert.Users;
using EduCopter.Persistency.DataBase.Domain.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Mission
{
    public static class StudentMissionConverter
    {
        public static StudentMission Convert(EFStudentMission ef)
        {
            return new()
            {
                Mission = MissionConverter.Convert(ef.Mission),
                Student = StudentConverter.Convert(ef.Student)
            };
        }

        public static EFStudentMission Convert(StudentMission e)
        {
            return new()
            {
                MissionId = e.Mission.Id,
                Mission = MissionConverter.Convert(e.Mission),
                StudentId = e.Student.Id,
                Student = StudentConverter.Convert(e.Student)
            };
        }
    }
}
