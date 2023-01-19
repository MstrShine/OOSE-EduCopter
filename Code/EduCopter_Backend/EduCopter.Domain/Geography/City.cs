namespace EduCopter.Domain.Geography
{
    public class City : Entity
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Guid ProvinceId { get; set; }

        public Guid MapId { get; set; }
    }
}
