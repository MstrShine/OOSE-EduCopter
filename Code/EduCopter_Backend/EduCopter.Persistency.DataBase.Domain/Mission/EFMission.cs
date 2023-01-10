using EduCopter.Domain.Geography;
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

        public EFMap Map { get; set; }

        public EFTeacher Teacher { get; set; }

        public List<EFCity> Cities { get; set; } = new();
    }
}
