using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain
{
    public class EFSchool : EFEntity
    {
        public string Name { get; set; }

        public List<EFClass> Classes { get; set; } = new();

        public List<EFStudent> Students { get; set; } = new();

        public List<EFTeacher> Teachers { get; set; } = new();
    }
}
