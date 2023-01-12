using EduCopter.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Mission
{
    public class StudentMission
    {
        public Guid StudentId { get; set; }

        public Guid MissionId { get; set; }
    }
}
