using EduCopter.Logic.Convert.Game;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Logic.Convert.Users;
using EduCopter.Persistency.DataBase.Domain.Mission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
