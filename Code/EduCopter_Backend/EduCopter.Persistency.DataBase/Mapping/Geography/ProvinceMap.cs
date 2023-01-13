using EduCopter.Persistency.DataBase.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class ProvinceMap : EntityMap<EFProvince>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFProvince> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasOne<EFCountry>().WithMany().HasForeignKey(x => x.CountryId);
        }
    }
}
