using EduCopter.Domain.Users;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class StudentController : AbstractEntityController<Student>
    {
        //public StudentController(IEntityRepository<Student> repository) : base(repository)
        //{
        //}
    }
}
