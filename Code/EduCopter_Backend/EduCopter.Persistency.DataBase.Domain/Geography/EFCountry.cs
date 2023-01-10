using EduCopter.Persistency.DataBase.Domain;

namespace EduCopter.Domain.Geography
{
    public class EFCountry : EFEntity
    {
        public string Name { get; set; }

        public List<EFProvince> Provinces { get; set; } = new();

    }
}
