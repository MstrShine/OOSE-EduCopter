using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.School
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class SchoolController : AbstractEntityController<Domain.School.School>
    {
        public SchoolController(IEntityLogic<Domain.School.School> logic) : base(logic)
        {
        }
    }
}
