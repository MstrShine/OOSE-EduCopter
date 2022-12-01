using EduCopter.Domain.Geography;
using EduCopter.Domain.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.Cache.Models
{
    public class MissionCacheModel
    {
        public Guid Id { get; set; }

        public DateTime LastAccessed { get { return _LastAccessed; } }

        private DateTime _LastAccessed = DateTime.Now;

        public Mission Mission { get; set; }

        public MissionCacheModel(Mission mission)
        {
            this.Id = new Guid();
            this.Mission = mission;
        }

        public void AddCities(List<City> cities)
        {
            this.Mission.Cities.AddRange(cities);
            this._LastAccessed = DateTime.Now;
        }
    }
}
