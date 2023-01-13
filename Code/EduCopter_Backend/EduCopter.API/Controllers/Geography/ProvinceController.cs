using EduCopter.Domain.Geography;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Geography
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class ProvinceController : AbstractEntityController<Province>
    {
        public ProvinceController(IEntityLogic<Province> logic) : base(logic)
        {
        }
    }
}
