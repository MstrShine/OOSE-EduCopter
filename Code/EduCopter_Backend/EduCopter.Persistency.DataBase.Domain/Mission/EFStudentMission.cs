using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Mission
{
    [Table("StudentMission")]
    public class EFStudentMission
    {
        public Guid StudentId { get; set; }

        public Guid MissionId { get; set; }
    }
}
