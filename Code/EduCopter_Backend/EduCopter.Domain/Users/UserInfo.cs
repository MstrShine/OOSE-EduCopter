using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Domain.Users
{
    public class UserInfo : Entity
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
