using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Users
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class StudentController : AbstractUserController<Student>
    {
        public StudentController(IEntityLogic<Student> logic, IPasswordHandler passwordHandler) : base(logic, passwordHandler)
        {
        }
    }
}
