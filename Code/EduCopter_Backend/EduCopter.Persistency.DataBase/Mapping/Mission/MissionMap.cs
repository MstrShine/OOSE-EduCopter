using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Mission
{
    public class MissionMap : EntityMap<EFMission>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFMission> builder)
        {
            builder.Property(x => x.Date);

            builder.HasOne<EFMap>().WithMany().HasForeignKey(x => x.MapId);
            builder.HasOne<EFTeacher>().WithMany().HasForeignKey(x => x.TeacherId);
        }
    }
}
