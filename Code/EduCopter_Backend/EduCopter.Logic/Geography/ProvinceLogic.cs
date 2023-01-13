using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Geography
{
    public class ProvinceLogic : BaseEntityLogic<Province, EFProvince>
    {
        public ProvinceLogic(IEntityRepository<EFProvince> repository) : base(repository)
        {
        }

        protected override Province Convert(EFProvince entity)
        {
            throw new NotImplementedException();
        }

        protected override EFProvince Convert(Province entity)
        {
            throw new NotImplementedException();
        }
    }
}
