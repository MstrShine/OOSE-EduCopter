using EduCopter.Persistency.DataBase.Extensions;

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

            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.InjectStylesheet("/swagger-ui/SwaggerDark.css");
            });

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