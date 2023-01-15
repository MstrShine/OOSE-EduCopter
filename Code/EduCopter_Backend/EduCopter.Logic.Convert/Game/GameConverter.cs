using EduCopter.Persistency.DataBase.Domain.Game;

namespace EduCopter.Logic.Convert.Game
{
    public static class GameConverter
    {
        public static Domain.Game.Game Convert(EFGame ef)
        {
            return new()
            {
                Id = ef.Id,
                Date = ef.Date,
                MissionId = ef.MissionId,
                StudentId = ef.StudentId,
            };
        }

        public static EFGame Convert(Domain.Game.Game e)
        {
            return new()
            {
                Id = e.Id,
                Date = e.Date,
                MissionId = e.MissionId,
                StudentId = e.StudentId,
            };
        }
    }
}
