using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Geography
{
    public class CountryLogic : BaseEntityLogic<Country, EFCountry>
    {
        public CountryLogic(IEntityRepository<EFCountry> repository) : base(repository)
        {
        }

        protected override Country Convert(EFCountry entity)
        {
            throw new NotImplementedException();
        }

        protected override EFCountry Convert(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
