using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Geography
{
    public class EFMap : EFEntity
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public List<EFMission> Missions { get; set; }
    }
}
