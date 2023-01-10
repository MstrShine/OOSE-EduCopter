using EduCopter.Persistency.DataBase.Domain.Game;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Game
{
    public class GameMap : EntityMap<EFGame>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFGame> builder)
        {
            builder.Property(x => x.Date);

            builder.HasOne(x => x.Student).WithMany(x => x.Games).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Mission).WithMany(x => x.Games).HasForeignKey(x => x.MissionId);
        }
    }
}
