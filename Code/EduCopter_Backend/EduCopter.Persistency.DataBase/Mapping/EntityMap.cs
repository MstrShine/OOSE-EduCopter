using EduCopter.Domain;
using EduCopter.Persistency.DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping
{
    public abstract class EntityMap<EF, E> : IEntityTypeConfiguration<EF> where EF : EFEntity<E, EF> where E : Entity, new()
    {
        public void Configure(EntityTypeBuilder<EF> builder)
        {
            builder.HasKey(e => e.Id);

            ConfigureExtension(builder);
        }

        public abstract void ConfigureExtension(EntityTypeBuilder<EF> builder);
    }
}
