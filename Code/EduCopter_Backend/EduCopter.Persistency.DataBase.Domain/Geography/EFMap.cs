using EduCopter.Persistency.DataBase.Domain.Mission;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Geography
{
    [Table("Map")]
    public class EFMap : EFEntity
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public List<EFMission> Missions { get; set; }
    }
}
