using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class CountryMap : EntityMap<EFCountry>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFCountry> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne<EFMap>().WithOne().HasForeignKey<EFCountry>(x => x.MapId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
