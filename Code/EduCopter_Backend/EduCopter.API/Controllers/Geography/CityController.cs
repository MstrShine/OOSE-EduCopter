using EduCopter.Domain.Geography;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Geography
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class CityController : AbstractEntityController<City>
    {
        public CityController(IEntityLogic<City> logic) : base(logic)
        {
        }
    }
}
