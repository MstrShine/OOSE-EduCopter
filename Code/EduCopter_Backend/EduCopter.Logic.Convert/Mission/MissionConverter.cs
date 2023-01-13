using EduCopter.Persistency.DataBase.Domain.Mission;

namespace EduCopter.Logic.Convert.Mission
{
    public static class MissionConverter
    {
        public static Domain.Mission.Mission Convert(EFMission ef)
        {
            return new()
            {
                Id = ef.Id,
                Date = ef.Date,
                MapId = ef.MapId,
                TeacherId = ef.TeacherId,
            };
        }

        public static EFMission Convert(Domain.Mission.Mission e)
        {
            return new()
            {
                Id = e.Id,
                Date = e.Date,
                MapId = e.MapId,
                TeacherId = e.TeacherId,
            };
        }
    }
}
