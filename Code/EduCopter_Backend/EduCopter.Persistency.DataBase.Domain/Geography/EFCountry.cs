using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Geography
{
    [Table("Country")]
    public class EFCountry : EFEntity
    {
        public string Name { get; set; }

        public Guid MapId { get; set; }
    }
}
