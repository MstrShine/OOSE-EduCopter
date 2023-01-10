using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Mission
{
    [Table("Mission")]
    public class EFMission : EFEntity
    {
        public DateTime Date { get; set; }

        public Guid MapId { get; set; }

        public EFMap Map { get; set; }

        public Guid TeacherId { get; set; }

        public EFTeacher Teacher { get; set; }

        public List<EFMissionCity> MissionCities { get; set; }

        public List<EFStudentMission> StudentMissions { get; set; }

        public List<EFGame> Games { get; set; }
    }
}
