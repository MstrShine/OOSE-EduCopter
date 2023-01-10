using EduCopter.Domain.Geography;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Mission
{
    [Table("MissionCity")]
    public class EFMissionCity
    {
        public int MissionOrder { get; set; }

        public Guid MissionId { get; set; }

        public virtual EFMission Mission { get; set; }

        public Guid CityId { get; set; }

        public virtual EFCity City { get; set; }
    }
}
