using EduCopter.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Mission;

namespace EduCopter.Logic.Convert.Mission
{
    public static class StudentMissionConverter
    {
        public static StudentMission Convert(EFStudentMission ef)
        {
            return new()
            {
                MissionId = ef.MissionId,
                StudentId = ef.StudentId
            };
        }

        public static EFStudentMission Convert(StudentMission e)
        {
            return new()
            {
                MissionId = e.MissionId,
                StudentId = e.StudentId,
            };
        }
    }
}
