using EduCopter.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Domain.Users
{
    public class EFStudent : EFEntity<Student, EFStudent>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        protected override EFStudent _FromDomain(Student entity)
        {
            return new EFStudent()
            {
                UserName = entity.UserName,
                Password = entity.Password,
            };
        }

        protected override void _ToDomain(ref Student entity)
        {
            entity.UserName = UserName;
            entity.Password = Password;
        }
    }
}
