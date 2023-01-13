using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Game
{
    [Table("GameCity")]
    public class EFGameCity
    {
        public double Score { get; set; }

        public Guid GameId { get; set; }

        public Guid CityId { get; set; }

        public EFGameCity() { }

        public EFGameCity(double score, Guid gameId, Guid cityId)
        {
            Score = score;
            GameId = gameId;
            CityId = cityId;
        }
    }
}
