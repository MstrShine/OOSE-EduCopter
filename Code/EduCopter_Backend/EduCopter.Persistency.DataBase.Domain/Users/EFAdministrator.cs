using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Users
{
    [Table("Administrator")]
    public class EFAdministrator : EFEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
