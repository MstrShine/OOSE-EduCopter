using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Mission
{
    [Table("Mission")]
    public class EFMission : EFEntity
    {
        public DateTime Date { get; set; }

        public Guid MapId { get; set; }

        public Guid TeacherId { get; set; }

    }
}
