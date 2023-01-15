namespace EduCopter.Domain.Geography
{
    public class Country : Entity
    {
        public string Name { get; set; }

        public Guid MapId { get; set; }

        public Country() { }
    }
}
