using EduCopter.Domain.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Mission
{
    public class MissionCity
    {
        public int MissionOrder { get; set; }

        public Guid MissionId { get; set; }

        public Guid CityId { get; set; }
    }
}
