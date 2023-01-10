using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Users
{
    public class AdministratorMap : EntityMap<EFAdministrator>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFAdministrator> builder)
        {
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}
