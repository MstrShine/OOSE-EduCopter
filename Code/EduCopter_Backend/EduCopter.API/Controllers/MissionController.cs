using EduCopter.Domain.Mission;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class MissionController : AbstractEntityController<Mission>
    {
        public MissionController(IEntityLogic<Mission> logic) : base(logic)
        {
        }
    }
}
