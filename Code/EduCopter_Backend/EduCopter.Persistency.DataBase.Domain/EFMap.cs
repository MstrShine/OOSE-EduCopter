using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain
{
    public class EFMap : EFEntity
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public Guid TeacherId { get; set; }
    }
}
