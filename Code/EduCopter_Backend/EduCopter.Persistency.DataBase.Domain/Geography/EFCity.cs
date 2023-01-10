using EduCopter.Persistency.DataBase.Domain;
using EduCopter.Persistency.DataBase.Domain.Mission;

namespace EduCopter.Domain.Geography
{
    public class EFCity : EFEntity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public Guid ProvinceId { get; set; }

        public virtual EFProvince Province { get; set; }

        public virtual List<EFMission> Missions { get; set; }
    }
}
