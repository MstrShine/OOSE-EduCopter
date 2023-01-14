using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
