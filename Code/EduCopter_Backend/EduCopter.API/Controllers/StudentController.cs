using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class StudentController : AbstractEntityController<Student>
    {
        public StudentController(IEntityLogic<Student> logic) : base(logic)
        {
        }
    }
}
