using EduCopter.API.Models;
using EduCopter.Domain.Geography;
using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Geography
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = RoleConstants.StudentAndTeacher)]
    public class CityController : AbstractEntityController<City>
    {
        public CityController(IEntityLogic<City> logic) : base(logic)
        {
        }
    }
}
