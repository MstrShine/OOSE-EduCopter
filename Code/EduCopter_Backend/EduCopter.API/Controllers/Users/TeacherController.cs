using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Users
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class TeacherController : AbstractEntityController<Teacher>
    {
        public TeacherController(IEntityLogic<Teacher> logic) : base(logic)
        {
        }
    }
}
