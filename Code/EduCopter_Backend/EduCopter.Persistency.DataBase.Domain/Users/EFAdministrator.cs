using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Users
{
    public class EFAdministrator : EFEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
