using EduCopter.Persistency.DataBase.Domain.Mission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Mission
{
    public class StudentMissionMap : IEntityTypeConfiguration<EFStudentMission>
    {
        public void Configure(EntityTypeBuilder<EFStudentMission> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.MissionId });

            builder.HasOne(x => x.Student).WithMany(x => x.StudentMissions).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Mission).WithMany(x => x.StudentMissions).HasForeignKey(x => x.MissionId);
        }
    }
}
