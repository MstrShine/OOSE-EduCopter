using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Domain.Geography
{
    public class EFCity : EFEntity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public Guid ProvinceId { get; set; }
    }
}
