using EduCopter.Persistency.DataBase.Domain.Game;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Game
{
    public class GameMap : EntityMap<EFGame>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFGame> builder)
        {
            builder.Property(x => x.Date);

            builder.HasOne(x => x.Student).WithMany(x => x.Games).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Mission).WithMany(x => x.Games).HasForeignKey(x => x.MissionId);
        }
    }
}
