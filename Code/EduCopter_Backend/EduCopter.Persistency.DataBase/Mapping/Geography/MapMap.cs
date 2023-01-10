using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class MapMap : EntityMap<EFMap>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFMap> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Path).IsRequired();
        }
    }
}
