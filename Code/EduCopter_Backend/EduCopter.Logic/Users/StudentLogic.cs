using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Users
{
    public class StudentLogic : BaseEntityLogic<Student, EFStudent>
    {
        public StudentLogic(IEntityRepository<EFStudent> repository) : base(repository)
        {
        }

        protected override Student Convert(EFStudent entity)
        {

        }

        protected override EFStudent Convert(Student entity)
        {

        }
    }
}
