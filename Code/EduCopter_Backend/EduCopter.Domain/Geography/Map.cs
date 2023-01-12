namespace EduCopter.Domain.Geography
{
    public class Map : Entity
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public List<Mission.Mission> Missions { get; set; }
    }
}
