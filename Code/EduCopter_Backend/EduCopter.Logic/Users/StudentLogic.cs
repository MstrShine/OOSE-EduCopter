﻿using EduCopter.Domain.Users;
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

        public override Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<Student> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<List<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Task<Student> SaveOrUpdate(Student entity)
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
