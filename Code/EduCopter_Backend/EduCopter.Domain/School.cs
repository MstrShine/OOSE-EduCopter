using EduCopter.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain
{
    public class School : Entity
    {
        public string Name { get; set; }

        public List<Class> Classes { get; set; } = new();

        public List<Student> Students { get; set; } = new();

        public List<Teacher> Teachers { get; set; } = new();

        public School() { }
    }
}
