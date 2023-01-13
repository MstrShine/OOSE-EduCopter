using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Geography
{
    public class CityLogic : BaseEntityLogic<City, EFCity>
    {
        public CityLogic(IEntityRepository<EFCity> repository) : base(repository)
        {
        }

        protected override City Convert(EFCity entity)
        {
            throw new NotImplementedException();
        }

        protected override EFCity Convert(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
