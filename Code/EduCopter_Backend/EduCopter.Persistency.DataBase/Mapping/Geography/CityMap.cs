﻿using EduCopter.Domain.Geography;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Geography
{
    public class CityMap : EntityMap<EFCity>
    {
        public override void ConfigureExtension(EntityTypeBuilder<EFCity> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Population);

            builder.HasOne(x => x.Province).WithMany(x => x.Cities).HasForeignKey(x => x.ProvinceId);
        }
    }
}