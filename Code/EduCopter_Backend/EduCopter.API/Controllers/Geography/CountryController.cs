using EduCopter.Domain.Geography;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Geography
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class CountryController : AbstractEntityController<Country>
    {
        public CountryController(IEntityLogic<Country> logic) : base(logic)
        {
        }
    }
}
