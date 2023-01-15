using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Mission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Mission
{
    public class MissionCityMap : IEntityTypeConfiguration<EFMissionCity>
    {
        public void Configure(EntityTypeBuilder<EFMissionCity> builder)
        {
            builder.HasKey(x => new { x.CityId, x.MissionId });
            builder.Property(x => x.MissionOrder).IsRequired();

            builder.HasOne<EFMission>().WithMany().HasForeignKey(x => x.MissionId);
            builder.HasOne<EFCity>().WithMany().HasForeignKey(x => x.CityId);
        }
    }
}
