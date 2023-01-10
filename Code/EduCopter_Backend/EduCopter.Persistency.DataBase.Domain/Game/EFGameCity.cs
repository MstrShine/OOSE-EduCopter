using EduCopter.Domain.Geography;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Game
{
    [Table("GameCity")]
    public class EFGameCity
    {
        public double Score { get; set; }

        public Guid GameId { get; set; }

        public virtual EFGame Game { get; set; }

        public Guid CityId { get; set; }
        
        public virtual EFCity City { get; set; }

    }
}
