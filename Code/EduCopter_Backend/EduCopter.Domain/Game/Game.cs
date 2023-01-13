namespace EduCopter.Domain.Game
{
    public class Game : Entity
    {
        public DateTime Date { get; set; }

        public Guid StudentId { get; set; }

        public Guid MissionId { get; set; }
    }
}
