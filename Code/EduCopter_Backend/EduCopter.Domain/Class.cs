using EduCopter.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain
{
    public class Class : Entity
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; } = new(); 

        public Teacher Teacher { get; set; }

        public Guid SchoolId { get; set; }

        public Class() { }
    }
}
