using EduCopter.Persistency.DataBase.Domain;
namespace EduCopter.Domain.Geography
{
    public class EFProvince : EFEntity
    {
        public string Name { get; set; }

        public Guid CountryId { get; set; }

        public EFCountry Country { get; set; }

        public List<EFCity> Cities { get; set; } = new();
    }
}
