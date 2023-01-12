using EduCopter.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Game
{
    public class Game : Entity
    {
        public DateTime Date { get; set; }

        public Guid StudentId { get; set; }

        public Guid MissionId { get; set; }
    }
}
