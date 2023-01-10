using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Mission
{
    public class EFMission : EFEntity
    {
        public DateTime Date { get; set; }

        public Guid MapId { get; set; }

        public virtual EFMap Map { get; set; }

        public Guid TeacherId { get; set; }

        public virtual EFTeacher Teacher { get; set; }

        public virtual List<EFCity> Cities { get; set; } = new();
    }
}
