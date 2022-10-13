using EduCopter.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Repository.Sessions.Users
{
    public class StudentRepositorySession : EntityRepositorySession<Student>
    {
        protected override DbSet<Student> Table => _context.Students;

        public StudentRepositorySession(EduCopterContext context) : base(context)
        {
        }

        public override Task<Student> SaveOrUpdate(Student entity)
        {
            return base.SaveOrUpdate(entity);
        }
    }
}
