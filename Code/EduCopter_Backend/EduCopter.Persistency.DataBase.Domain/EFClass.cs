using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain
{
    public class EFClass : EFEntity
    {
        public string Name { get; set; }

        public List<EFStudent> Students { get; set; } = new();

        public EFTeacher Teacher { get; set; }

        public Guid SchoolId { get; set; }
    }
}
