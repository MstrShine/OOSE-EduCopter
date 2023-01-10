using EduCopter.Persistency.DataBase.Domain.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.School
{
    [Table("School")]
    public class EFSchool : EFEntity
    {
        public string Name { get; set; }

        public List<EFClass> Classes { get; set; }

        public List<EFStudent> Students { get; set; }

        public List<EFTeacher> Teachers { get; set; }
    }
}
