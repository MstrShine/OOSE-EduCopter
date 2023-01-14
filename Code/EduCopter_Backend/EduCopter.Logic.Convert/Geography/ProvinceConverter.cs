using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;

namespace EduCopter.Logic.Convert.Geography
{
    public static class ProvinceConverter
    {
        public static Province Convert(EFProvince ef)
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
                CountryId = ef.CountryId,
            };
        }

        public static EFProvince Convert(Province e)
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                CountryId = e.CountryId,
            };
        }
    }
}
