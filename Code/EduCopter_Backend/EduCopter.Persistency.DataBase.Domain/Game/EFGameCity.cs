using EduCopter.Domain.Geography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduCopter.Persistency.DataBase.Domain.Game
{
    [Table("GameCity")]
    public class EFGameCity
    {
        public double Score { get; set; }

        public Guid GameId { get; set; }

        public EFGame Game { get; set; }

        public Guid CityId { get; set; }

        public EFCity City { get; set; }

    }
}
