using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Users
{
    public class Student : UserInfo
    {
        public Guid SchoolId { get; set; }

        public Guid ClassId { get; set; }

        public Student() { }
    }
}
