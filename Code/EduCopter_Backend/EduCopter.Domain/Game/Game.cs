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

        public Student Student { get; set; }

        public Mission.Mission Mission { get; set; }

        public List<GameCity> GameCities { get; set; }
    }
}
