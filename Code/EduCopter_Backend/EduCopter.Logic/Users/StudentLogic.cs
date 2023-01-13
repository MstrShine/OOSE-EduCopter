using EduCopter.Domain.Users;
using EduCopter.Logic.Convert.Users;
using EduCopter.Persistency.DataBase.Domain.Users;
using EduCopter.Persistency.DataBase.Repositories.Interfaces;

namespace EduCopter.Logic.Users
{
    public class StudentLogic : BaseEntityLogic<Student, EFStudent>
    {
        public StudentLogic(IEntityRepository<EFStudent> repository) : base(repository)
        {
        }

        protected override Student Convert(EFStudent entity)
        {
            return StudentConverter.Convert(entity);
        }

        protected override EFStudent Convert(Student entity)
        {
            return StudentConverter.Convert(entity);
        }
    }
}
