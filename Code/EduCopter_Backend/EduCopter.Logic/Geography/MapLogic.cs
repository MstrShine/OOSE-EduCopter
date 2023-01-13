using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Geography
{
    public class MapLogic : BaseEntityLogic<Map, EFMap>
    {
        public MapLogic(IEntityRepository<EFMap> repository) : base(repository)
        {
        }

        protected override Map Convert(EFMap entity)
        {
            throw new NotImplementedException();
        }

        protected override EFMap Convert(Map entity)
        {
            throw new NotImplementedException();
        }
    }
}
