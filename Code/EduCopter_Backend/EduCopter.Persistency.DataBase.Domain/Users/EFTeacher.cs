using EduCopter.Persistency.DataBase.Domain.School;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Users
{
    [Table("Teacher")]
    public class EFTeacher : EFEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid ClassId { get; set; }

        public Guid SchoolId { get; set; }
    }
}
