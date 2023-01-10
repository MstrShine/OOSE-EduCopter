using EduCopter.Persistency.DataBase.Domain.School;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.School
{
    public class ClassMap : EntityMap<EFClass>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFClass> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne(x => x.School).WithMany(x => x.Classes).HasForeignKey(x => x.SchoolId);
        }
    }
}
