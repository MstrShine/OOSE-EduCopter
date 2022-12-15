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
