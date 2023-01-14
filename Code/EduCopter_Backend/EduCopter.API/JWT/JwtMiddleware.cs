using EduCopter.Domain.Options;
using EduCopter.Domain.Users;
using EduCopter.Logic.Interfaces;
using Microsoft.Extensions.Options;

namespace EduCopter.API.JWT
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ITokenService tokenService;
        private readonly JwtOptions jwtOptions;

        public JwtMiddleware(RequestDelegate next, ITokenService tokenService, IOptions<JwtOptions> appSettings)
        {
            this.next = next;
            this.tokenService = tokenService;
            jwtOptions = appSettings.Value;
        }

        public async Task Invoke(HttpContext context, IEntityLogic<Student> studentService, IEntityLogic<Teacher> teacherService, IEntityLogic<Administrator> adminService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                await AttachUserToContext(context, studentService, teacherService, adminService, token);

            await next(context);
        }

        private async Task AttachUserToContext(HttpContext context, IEntityLogic<Student> studentService, IEntityLogic<Teacher> teacherService, IEntityLogic<Administrator> adminService, string token)
        {
            bool isValid = tokenService.ValidateToken(jwtOptions.Key, jwtOptions.Issuer, jwtOptions.Audience, token, out string userName);

            if (isValid)
            {
                List<UserInfo> userInfos = new();
                userInfos.AddRange(await studentService.GetAll());
                userInfos.AddRange(await teacherService.GetAll());
                userInfos.AddRange(await adminService.GetAll());

                context.Items["User"] = userInfos.FirstOrDefault(x => x.Username == userName);
            }
        }
    }
}
