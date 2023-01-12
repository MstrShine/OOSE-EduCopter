using EduCopter.Persistency.DataBase.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Domain.Geography
{
    [Table("Province")]
    public class EFProvince : EFEntity
    {
        public string Name { get; set; }

        public Guid CountryId { get; set; }

    }
}
