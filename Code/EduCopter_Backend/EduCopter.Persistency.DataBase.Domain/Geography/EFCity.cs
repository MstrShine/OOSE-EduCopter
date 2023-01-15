using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Geography
{
    [Table("City")]
    public class EFCity : EFEntity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Guid ProvinceId { get; set; }

        public Guid MapId { get; set; }
    }
}
