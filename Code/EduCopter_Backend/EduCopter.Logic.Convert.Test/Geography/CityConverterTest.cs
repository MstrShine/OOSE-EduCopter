using EduCopter.Domain.Geography;
using EduCopter.Logic.Convert.Geography;
using EduCopter.Persistency.DataBase.Domain.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCopter.Logic.Convert.Test.Geography
{
    public class CityConverterTest
    {
        [Fact]
        public void GoodConvert_EF()
        {
            var ef = new EFCity()
            {
                Id = Guid.NewGuid(),
                MapId = Guid.NewGuid(),
                ProvinceId = Guid.NewGuid(),
                Name = "Test",
                Population = 420,
                X = 69,
                Y = 69
            };

            var e = CityConverter.Convert(ef);

            Assert.NotNull(e);
            Assert.Equal(ef.Id, e.Id);
            Assert.Equal(ef.MapId, e.MapId);
            Assert.Equal(ef.ProvinceId, e.ProvinceId);
            Assert.Equal(ef.Name, e.Name);
            Assert.Equal(ef.Population, e.Population);
            Assert.Equal(ef.X, e.X);
            Assert.Equal(ef.Y, e.Y);
        }

        [Fact]
        public void GoodConvert_E() 
        {
            var e = new City()
            {
                Id = Guid.NewGuid(),
                MapId = Guid.NewGuid(),
                ProvinceId = Guid.NewGuid(),
                Name = "Test",
                Population = 420,
                X = 69,
                Y = 69
            };

            var ef = CityConverter.Convert(e);

            Assert.NotNull(ef);
            Assert.Equal(e.Id, ef.Id);
            Assert.Equal(e.MapId, ef.MapId);
            Assert.Equal(e.ProvinceId, ef.ProvinceId);
            Assert.Equal(e.Name, ef.Name);
            Assert.Equal(e.Population, ef.Population);
            Assert.Equal(e.X, ef.X);
            Assert.Equal(e.Y, ef.Y);
        }
    }
}
