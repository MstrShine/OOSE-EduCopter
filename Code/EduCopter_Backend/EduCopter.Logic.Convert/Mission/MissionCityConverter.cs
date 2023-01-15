using EduCopter.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Mission;

namespace EduCopter.Logic.Convert.Mission
{
    public static class MissionCityConverter
    {
        public static MissionCity Convert(EFMissionCity ef)
        {
            return new()
            {
                MissionOrder = ef.MissionOrder,
                CityId = ef.CityId,
                MissionId = ef.MissionId,
            };
        }

        public static EFMissionCity Convert(MissionCity e)
        {
            return new()
            {
                MissionOrder = e.MissionOrder,
                CityId = e.CityId,
                MissionId = e.MissionId,
            };
        }
    }
}
