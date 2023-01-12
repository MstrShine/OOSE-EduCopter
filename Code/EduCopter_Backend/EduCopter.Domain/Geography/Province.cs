namespace EduCopter.Domain.Geography
{
    public class Province : Entity
    {
        public string Name { get; set; }

        public Country Country { get; set; }

        public List<City> Cities { get; set; }
    }
}
