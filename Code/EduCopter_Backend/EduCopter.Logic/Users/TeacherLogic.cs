using EduCopter.Domain.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Users
{
    public class TeacherLogic : BaseEntityLogic<Teacher, EFTeacher>
    {
        public TeacherLogic(IEntityRepository<EFTeacher> repository) : base(repository)
        {
        }

        protected override Teacher Convert(EFTeacher entity)
        {
            throw new NotImplementedException();
        }

        protected override EFTeacher Convert(Teacher entity)
        {
            throw new NotImplementedException();
        }
    }
}
