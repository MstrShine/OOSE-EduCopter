using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Users
{
    public class Teacher : UserInfo
    {
        public Guid ClassId { get; set; }

        public Guid SchoolId { get; set; }

        public Teacher() { }
    }
}
