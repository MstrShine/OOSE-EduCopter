using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Users
{
    public class StudentMap : EntityMap<EFStudent>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFStudent> builder)
        {
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();

            builder.HasOne(x => x.School).WithMany(x => x.Students).HasForeignKey(x => x.SchoolId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Class).WithMany(x => x.Students).HasForeignKey(x => x.ClassId);
        }
    }
}
