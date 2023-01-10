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

        public EFStudent Student { get; set; }

        public Guid MissionId { get; set; }

        public EFMission Mission { get; set; }

        public List<EFGameCity> GameCities { get; set; }
    }
}
