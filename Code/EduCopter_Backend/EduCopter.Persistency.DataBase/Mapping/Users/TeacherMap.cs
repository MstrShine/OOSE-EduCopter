using EduCopter.Persistency.DataBase.Domain.School;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Users
{
    public class TeacherMap : EntityMap<EFTeacher>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFTeacher> builder)
        {
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();

            builder.HasOne<EFSchool>().WithMany().HasForeignKey(x => x.SchoolId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<EFClass>().WithOne().HasForeignKey<EFTeacher>(x => x.ClassId);
        }
    }
}
