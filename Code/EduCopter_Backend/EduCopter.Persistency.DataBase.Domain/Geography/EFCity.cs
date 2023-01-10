using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Mission;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Domain.Geography
{
    [Table("City")]
    public class EFCity : EFEntity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public Guid ProvinceId { get; set; }

        public EFProvince Province { get; set; }

        public List<EFMissionCity> MissionCities { get; set; }

        public List<EFGameCity> GameCities { get; set; }
    }
}
