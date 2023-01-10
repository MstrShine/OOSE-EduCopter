using EduCopter.Persistency.DataBase.Domain.School;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.School
{
    public class ClassMap : EntityMap<EFClass>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFClass> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.Teacher).WithOne(x => x.Class).HasForeignKey<EFClass>(x => x.TeacherId);

            builder.HasOne(x => x.School).WithMany(x => x.Classes).HasForeignKey(x => x.SchoolId);
        }
    }
}
