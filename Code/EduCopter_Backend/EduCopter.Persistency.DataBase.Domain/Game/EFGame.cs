using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Game
{
    [Table("Game")]
    public class EFGame : EFEntity
    {
        public DateTime Date { get; set; }

        public Guid StudentId { get; set; }

        public virtual EFStudent Student { get; set; }

        public Guid MissionId { get; set; }

        public virtual EFMission Mission { get; set; }

        public List<EFGameCity> GameCities { get; set; }
    }
}
