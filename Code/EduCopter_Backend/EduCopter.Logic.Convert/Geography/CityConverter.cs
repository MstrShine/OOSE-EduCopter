using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;

namespace EduCopter.Logic.Convert.Geography
{
    public static class CityConverter
    {
        public static City Convert(EFCity ef)
        {
            return new()
            {
                Id = ef.Id,
                Name = ef.Name,
                Population = ef.Population,
                ProvinceId = ef.ProvinceId,
            };
        }

        public static EFCity Convert(City e)
        {
            return new()
            {
                Id = e.Id,
                Name = e.Name,
                Population = e.Population,
                ProvinceId = e.ProvinceId,
            };
        }
    }
}
