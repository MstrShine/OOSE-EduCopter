using EduCopter.Persistency.DataBase.Domain.School;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.School
{
    public class ClassMap : EntityMap<EFClass>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFClass> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne<EFSchool>().WithMany().HasForeignKey(x => x.SchoolId);
        }
    }
}
