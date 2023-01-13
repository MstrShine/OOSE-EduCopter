using EduCopter.Domain.Geography;

namespace EduCopter.Domain.Mission
{
    public class Mission : Entity
    {
        public DateTime Date { get; set; }

        public Guid MapId { get; set; }

        public Guid TeacherId { get; set; }

        public List<City> Cities { get; set; } = new();
    }
}
