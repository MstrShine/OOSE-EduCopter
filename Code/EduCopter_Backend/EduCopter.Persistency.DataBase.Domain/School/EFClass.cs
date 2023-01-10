using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.School
{
    public class EFClass : EFEntity
    {
        public string Name { get; set; }

        public Guid TeacherId { get; set; }

        public virtual EFTeacher Teacher { get; set; }

        public Guid SchoolId { get; set; }

        public virtual EFSchool School { get; set; }

        public List<EFStudent> Students { get; set; } = new();
    }
}
