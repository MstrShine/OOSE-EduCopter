using EduCopter.Domain.Geography;
using EduCopter.Domain.Mission;

namespace EduCopter.Persistency.Cache.Models
{
    public class MissionCacheModel
    {
        public Guid Id { get; set; }

        public DateTime LastAccessed { get { return _LastAccessed; } }

        private DateTime _LastAccessed { get; set; } = DateTime.Now;

        public Mission Mission { get; set; }

        public MissionCacheModel(Mission mission)
        {
            this.Id = new Guid();
            this.Mission = mission;
        }

        public void AddCities(List<City> cities)
        {
            // Getting cities out of var cities except the ones allready in the mission
            var distinct = cities.Except(this.Mission.Cities).ToList();

            this.Mission.Cities.AddRange(distinct);
            this._LastAccessed = DateTime.Now;
        }
    }
}
