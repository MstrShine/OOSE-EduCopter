using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Game;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCopter.Persistency.DataBase.Mapping.Game
{
    public class GameCityMap : IEntityTypeConfiguration<EFGameCity>
    {
        public void Configure(EntityTypeBuilder<EFGameCity> builder)
        {
            builder.HasKey(x => new { x.CityId, x.GameId });
            builder.Property(x => x.Score).IsRequired();

            builder.HasOne<EFCity>().WithMany().HasForeignKey(x => x.CityId);
            builder.HasOne<EFGame>().WithMany().HasForeignKey(x => x.GameId);
        }
    }
}
