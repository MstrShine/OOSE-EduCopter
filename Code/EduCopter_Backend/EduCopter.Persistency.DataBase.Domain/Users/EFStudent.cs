using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.School;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Users
{
    [Table("Student")]
    public class EFStudent : EFEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid SchoolId { get; set; }

        public EFSchool School { get; set; }

        public Guid ClassId { get; set; }

        public EFClass Class { get; set; }

        public List<EFStudentMission> StudentMissions { get; set; }

        public List<EFGame> Games { get; set; }
    }
}
