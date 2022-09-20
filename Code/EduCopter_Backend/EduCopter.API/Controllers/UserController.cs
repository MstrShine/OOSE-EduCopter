using EduCopter.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class UserController : BaseEntityController<User>
    {
    }
}
