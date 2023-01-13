using EduCopter.Domain.School;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.School
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class ClassController : AbstractEntityController<Class>
    {
        public ClassController(IEntityLogic<Class> logic) : base(logic)
        {
        }
    }
}
