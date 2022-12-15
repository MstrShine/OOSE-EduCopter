using EduCopter.Persistency.DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping
{
    public abstract class EntityMap<EF> : IEntityTypeConfiguration<EF> where EF : EFEntity
    {
        public void Configure(EntityTypeBuilder<EF> builder)
        {
            builder.HasKey(e => e.Id);

            ConfigureExtension(builder);
        }

        public abstract void ConfigureExtension(EntityTypeBuilder<EF> builder);
    }
}
