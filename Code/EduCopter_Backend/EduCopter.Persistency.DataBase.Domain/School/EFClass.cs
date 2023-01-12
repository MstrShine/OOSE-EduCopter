using EduCopter.Persistency.DataBase.Domain.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.School
{
    [Table("Class")]
    public class EFClass : EFEntity
    {
        public string Name { get; set; }

        public Guid SchoolId { get; set; }
    }
}
