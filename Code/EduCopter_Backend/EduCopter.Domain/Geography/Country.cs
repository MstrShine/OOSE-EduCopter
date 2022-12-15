namespace EduCopter.Domain.Geography
{
    public class Country : Entity
    {
        public string Name { get; set; }

        public List<Province> Provinces { get; set; } = new();

        public Country() { }
    }
}
