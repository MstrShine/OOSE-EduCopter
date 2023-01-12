using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Users
{
    public static class AdministratorConverter
    {
        public static Administrator Convert(EFAdministrator ef)
        {
            return new()
            {
                Id = ef.Id,
                Username = ef.Username,
                Password = ef.Password,
            };
        }

        public static EFAdministrator Convert(Administrator e)
        {
            return new()
            {
                Id = e.Id,
                Username = e.Username,
                Password = e.Password
            };
        }
    }
}
