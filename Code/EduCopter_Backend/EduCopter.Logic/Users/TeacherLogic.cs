using EduCopter.Domain.Users;
using EduCopter.Logic.Convert.Users;
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
            return TeacherConverter.Convert(entity);
        }

        protected override EFTeacher Convert(Teacher entity)
        {
            return TeacherConverter.Convert(entity);
        }
    }
}
