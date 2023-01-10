using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Mission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Persistency.DataBase.Mapping.Game
{
    public class GameCityMap : IEntityTypeConfiguration<EFGameCity>
    {
        public void Configure(EntityTypeBuilder<EFGameCity> builder)
        {
            builder.Property(x => x.Score);

            builder.HasOne(x => x.City).WithMany(x => x.GameCities).HasForeignKey(x => x.CityId);
            builder.HasOne(x => x.Game).WithMany(x => x.GameCities).HasForeignKey(x => x.GameId);
        }
    }
}
