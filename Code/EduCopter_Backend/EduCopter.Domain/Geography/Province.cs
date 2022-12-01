using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Geography
{
    public class Province : Entity
    {
        public string Name { get; set; }

        public Guid CountryId { get; set; }

        public List<City> Cities { get; set; } = new();

        public Province() { }
    }
}
