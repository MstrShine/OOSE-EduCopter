using EduCopter.Persistency.DataBase.Domain.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.School
{
    [Table("Class")]
    public class EFClass : EFEntity
    {
        public string Name { get; set; }

        public Guid TeacherId { get; set; }

        public virtual EFTeacher Teacher { get; set; }

        public Guid SchoolId { get; set; }

        public virtual EFSchool School { get; set; }

        public List<EFStudent> Students { get; set; }
    }
}
