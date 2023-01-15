using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Mission
{
    [Table("StudentMission")]
    public class EFStudentMission
    {
        public Guid StudentId { get; set; }

        public Guid MissionId { get; set; }
    }
}
