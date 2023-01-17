﻿using EduCopter.API.JWT;
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
        private readonly IConfiguration configuration;

        private readonly IEntityLogic<Student> studentLogic;
        private readonly IEntityLogic<Teacher> teacherLogic;
        private readonly IEntityLogic<Administrator> administratorLogic;

        private readonly ITokenService tokenService;
        private readonly IPasswordHandler passwordHandler;

        public UserController(
            IConfiguration configuration,
            IEntityLogic<Student> studentLogic,
            IEntityLogic<Teacher> teacherLogic,
            IEntityLogic<Administrator> administratorLogic,
            ITokenService tokenService,
            IPasswordHandler passwordHandler)
        {
            this.configuration = configuration;
            this.studentLogic = studentLogic;
            this.teacherLogic = teacherLogic;
            this.administratorLogic = administratorLogic;
            this.tokenService = tokenService;
            this.passwordHandler = passwordHandler;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (loginModel == null || string.IsNullOrWhiteSpace(loginModel.Username) || string.IsNullOrWhiteSpace(loginModel.Password) || loginModel.SchoolId == Guid.Empty)
            {
                NoContent();
            }


            var students = await studentLogic.GetAll();
            var student = students.FirstOrDefault(x => x.Username == loginModel.Username && x.SchoolId == loginModel.SchoolId);
            if (student != null)
            {
                if (await passwordHandler.CheckPassword(student.Password, loginModel.Password))
                {
                    var token = tokenService.BuildToken(configuration["Jwt:Key"], configuration["Jwt:Issuer"], student);
                    return Ok(token);
                }
            }

            var teachers = await teacherLogic.GetAll();
            var teacher = teachers.FirstOrDefault(x => x.Username == loginModel.Username && x.SchoolId == loginModel.SchoolId);
            if (teacher != null)
            {
                if (await passwordHandler.CheckPassword(teacher.Password, loginModel.Password))
                {
                    var token = tokenService.BuildToken(configuration["Jwt:Key"], configuration["Jwt:Issuer"], teacher);
                    return Ok(token);
                }
            }

            var administrators = await administratorLogic.GetAll();
            var admin = administrators.FirstOrDefault(x => x.Username == loginModel.Username);
            if (admin != null)
            {
                if (await passwordHandler.CheckPassword(admin.Password, loginModel.Password))
                {
                    var token = tokenService.BuildToken(configuration["Jwt:Key"], configuration["Jwt:Issuer"], admin);
                    return Ok(token);
                }
            }

            return NotFound();
        }
    }
}
