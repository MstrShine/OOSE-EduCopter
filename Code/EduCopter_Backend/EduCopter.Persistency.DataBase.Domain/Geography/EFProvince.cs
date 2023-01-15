using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Geography
{
    [Table("Province")]
    public class EFProvince : EFEntity
    {
        public string Name { get; set; }

        public Guid CountryId { get; set; }

        public Guid MapId { get; set; }

    }
}
