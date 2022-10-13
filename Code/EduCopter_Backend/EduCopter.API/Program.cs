using EduCopter.Persistency.DataBase;
using EduCopter.Persistency.DataBase.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EduCopter.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Configure Services
            builder.Services.AddRepositories();
            builder.Services.AddDataBase();

            builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen(options =>
            {
                options.ResolveConflictingActions(description => description.First());
            });
            #endregion

            #region Configure App
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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