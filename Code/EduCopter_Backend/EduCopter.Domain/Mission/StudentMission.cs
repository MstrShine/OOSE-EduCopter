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
        public Student Student { get; set; }

        public Mission Mission { get; set; }
    }
}
