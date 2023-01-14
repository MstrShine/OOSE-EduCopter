using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class CityMap : EntityMap<EFCity>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFCity> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Population);
            builder.Property(x => x.X);
            builder.Property(x => x.Y);

            builder.HasOne<EFProvince>().WithMany().HasForeignKey(x => x.ProvinceId);
            builder.HasOne<EFMap>().WithOne().HasForeignKey<EFCity>(x => x.MapId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
