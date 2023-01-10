using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Users
{
    public class EFTeacher : EFEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid ClassId { get; set; }

        public virtual EFClass Class { get; set; }

        public Guid SchoolId { get; set; }

        public virtual EFSchool School { get; set; }
    }
}
