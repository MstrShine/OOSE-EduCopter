using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Repository.Sessions.Users
{
    public class StudentRepositorySession : EntityRepositorySession<Student, EFStudent>
    {
        protected override DbSet<EFStudent> Table => _context.Students;

        public StudentRepositorySession(EduCopterContext context) : base(context)
        {
        }
    }
}
