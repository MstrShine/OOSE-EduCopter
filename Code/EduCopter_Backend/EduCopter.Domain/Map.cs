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
