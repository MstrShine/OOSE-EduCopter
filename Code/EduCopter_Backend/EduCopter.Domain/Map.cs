using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain
{
    public class Map : Entity
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public Guid TeacherId { get; set; }

        public Map() { }
    }
}
