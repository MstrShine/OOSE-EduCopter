using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Game
{
    public class GameMap : EntityMap<EFGame>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFGame> builder)
        {
            builder.Property(x => x.Date);

            builder.HasOne<EFStudent>().WithMany().HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<EFMission>().WithMany().HasForeignKey(x => x.MissionId);
        }
    }
}
