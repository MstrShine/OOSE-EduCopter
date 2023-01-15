using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Geography
{
    [Table("Map")]
    public class EFMap : EFEntity
    {
        public string Name { get; set; }

        public string Path { get; set; }
    }
}
