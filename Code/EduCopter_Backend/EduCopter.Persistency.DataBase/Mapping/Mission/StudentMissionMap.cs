using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Mission
{
    public class StudentMissionMap : IEntityTypeConfiguration<EFStudentMission>
    {
        public void Configure(EntityTypeBuilder<EFStudentMission> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.MissionId });

            builder.HasOne<EFStudent>().WithMany().HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne<EFMission>().WithMany().HasForeignKey(x => x.MissionId);
        }
    }
}
