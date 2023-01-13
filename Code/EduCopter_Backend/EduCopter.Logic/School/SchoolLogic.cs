using EduCopter.Persistency.DataBase.Domain.School;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.School
{
    public class SchoolLogic : BaseEntityLogic<Domain.School.School, EFSchool>
    {
        public SchoolLogic(IEntityRepository<EFSchool> repository) : base(repository)
        {
        }

        protected override Domain.School.School Convert(EFSchool entity)
        {
            throw new NotImplementedException();
        }

        protected override EFSchool Convert(Domain.School.School entity)
        {
            throw new NotImplementedException();
        }
    }
}
