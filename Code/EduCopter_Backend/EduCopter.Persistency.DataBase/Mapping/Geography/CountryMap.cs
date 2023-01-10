using EduCopter.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class CountryMap : EntityMap<EFCountry>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFCountry> builder)
        {
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
