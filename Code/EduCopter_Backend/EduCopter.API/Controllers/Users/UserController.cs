using EduCopter.API.JWT;
using EduCopter.API.Models;
using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduCopter.API.Controllers.Users
{
    [ApiVersion("1")]
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private readonly IEntityLogic<Student> _studentLogic;
        private readonly IEntityLogic<Teacher> _teacherLogic;
        private readonly IEntityLogic<Administrator> _administratorLogic;

        private readonly ITokenService _tokenService;
        private readonly IPasswordHandler _passwordHandler;

        public UserController(
            IConfiguration configuration,
            IEntityLogic<Student> studentLogic,
            IEntityLogic<Teacher> teacherLogic,
            IEntityLogic<Administrator> administratorLogic,
            ITokenService tokenService,
            IPasswordHandler passwordHandler)
        {
            this._configuration = configuration;
            this._studentLogic = studentLogic;
            this._teacherLogic = teacherLogic;
            this._administratorLogic = administratorLogic;
            this._tokenService = tokenService;
            this._passwordHandler = passwordHandler;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (loginModel == null || string.IsNullOrWhiteSpace(loginModel.Username) || string.IsNullOrWhiteSpace(loginModel.Password) || loginModel.SchoolId == Guid.Empty)
            {
                NoContent();
            }


            var students = await _studentLogic.GetAll();
            var student = students.FirstOrDefault(x => x.Username == loginModel.Username && x.SchoolId == loginModel.SchoolId);
            if (student != null)
            {
                if (await _passwordHandler.CheckPassword(student.Password, loginModel.Password))
                {
                    var token = _tokenService.BuildToken(_configuration["Jwt:Key"], _configuration["Jwt:Issuer"], student);
                    return Ok(token);
                }
            }

            var teachers = await _teacherLogic.GetAll();
            var teacher = teachers.FirstOrDefault(x => x.Username == loginModel.Username && x.SchoolId == loginModel.SchoolId);
            if (teacher != null)
            {
                if (await _passwordHandler.CheckPassword(teacher.Password, loginModel.Password))
                {
                    var token = _tokenService.BuildToken(_configuration["Jwt:Key"], _configuration["Jwt:Issuer"], teacher);
                    return Ok(token);
                }
            }

            var administrators = await _administratorLogic.GetAll();
            var admin = administrators.FirstOrDefault(x => x.Username == loginModel.Username);
            if (admin != null)
            {
                if (await _passwordHandler.CheckPassword(admin.Password, loginModel.Password))
                {
                    var token = _tokenService.BuildToken(_configuration["Jwt:Key"], _configuration["Jwt:Issuer"], admin);
                    if (token != null)
                    {
                        HttpContext.Session.SetString("Token", token);
                        return Ok(token);
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }

            return NotFound();
        }

        [HttpPost("createpassword")]
        public async Task<IActionResult> CreatePassword(string password)
        {
            var created = await _passwordHandler.CreatePassword(password);

            return Ok(created);
        }
    }
}
