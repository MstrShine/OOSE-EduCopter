using EduCopter.API.JWT;
using EduCopter.Domain.Options;
using EduCopter.Logic.Extensions;
using EduCopter.Persistency.DataBase.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EduCopter.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors();

            // Add services to the container.
            #region Configure Services
            builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(JwtOptions.Position));

            builder.Services.AddRepositories();
            builder.Services.AddDataBase();
            builder.Services.AddLogic();

            builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen(options =>
            {
                options.ResolveConflictingActions(description => description.First());
            });

            builder.Services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromHours(1);
            });
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddTransient<ITokenService, TokenService>();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                });

            #endregion

            #region Configure App
            var app = builder.Build();


            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.InjectStylesheet("/swagger-ui/SwaggerDark.css");
            });

            app.UseSession();
            app.Use(async (context, next) =>
            {
                var token = context.Session.GetString("Token");
                if (!string.IsNullOrEmpty(token))
                {
                    context.Request.Headers["Authorization"] = "Bearer " + token;
                }
                await next(context);
            });

            app.UseMiddleware<JwtMiddleware>();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod());
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
            #endregion
        }
    }
}