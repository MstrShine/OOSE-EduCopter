using EduCopter.Persistency.DataBase.Domain.School;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.School
{
    public class SchoolMap : EntityMap<EFSchool>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFSchool> builder)
        {
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
