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

        public override void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Student Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public override List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Student SaveOrUpdate(Student entity)
        {
            throw new NotImplementedException();
        }

        protected override Student Convert(EFStudent entity)
        {
            throw new NotImplementedException();
        }

        protected override EFStudent Convert(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
