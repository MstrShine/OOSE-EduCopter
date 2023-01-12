using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Game
{
    [Table("Game")]
    public class EFGame : EFEntity
    {
        public DateTime Date { get; set; }

        public Guid StudentId { get; set; }

        public Guid MissionId { get; set; }
    }
}
