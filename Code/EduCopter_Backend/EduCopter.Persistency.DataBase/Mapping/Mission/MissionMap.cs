using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Mission;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Mission
{
    public class MissionMap : EntityMap<EFMission>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFMission> builder)
        {
            builder.Property(x => x.Date);

            builder.HasOne(x => x.Map).WithMany(x => x.Missions).HasForeignKey(x => x.MapId);
            builder.HasOne(x => x.Teacher).WithMany().HasForeignKey(x => x.TeacherId);
        }
    }
}
