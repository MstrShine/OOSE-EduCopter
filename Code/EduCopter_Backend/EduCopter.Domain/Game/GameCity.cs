using EduCopter.Domain.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Game
{
    public class GameCity
    {
        public double Score { get; set; }

        public Game Game { get; set; }

        public City City { get; set; }
    }
}
