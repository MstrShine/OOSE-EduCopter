using EduCopter.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class CityMap : EntityMap<EFCity>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFCity> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Population);

            builder.HasOne(x => x.Province).WithMany(x => x.Cities).HasForeignKey(x => x.ProvinceId);
        }
    }
}
