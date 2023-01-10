using EduCopter.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class ProvinceMap : EntityMap<EFProvince>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFProvince> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.Country).WithMany(x => x.Provinces).HasForeignKey(x => x.CountryId);
        }
    }
}
