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
    public class MissionCityMap : IEntityTypeConfiguration<EFMissionCity>
    {
        public void Configure(EntityTypeBuilder<EFMissionCity> builder)
        {
            builder.HasKey(x => new { x.CityId, x.MissionId });
            builder.Property(x => x.MissionOrder).IsRequired();

            builder.HasOne(x => x.Mission).WithMany(x => x.MissionCities).HasForeignKey(x => x.MissionId);
            builder.HasOne(x => x.City).WithMany(x => x.MissionCities).HasForeignKey(x => x.CityId);
        }
    }
}
