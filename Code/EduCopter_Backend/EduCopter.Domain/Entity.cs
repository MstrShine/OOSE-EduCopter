using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
