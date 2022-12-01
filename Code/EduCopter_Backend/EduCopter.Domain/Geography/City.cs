using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Geography
{
    public class City : Entity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public Guid ProvinceId { get; set; }

        public City() { }
    }
}
