using EduCopter.Persistency.DataBase.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Domain.Geography
{
    [Table("Country")]
    public class EFCountry : EFEntity
    {
        public string Name { get; set; }
    }
}
